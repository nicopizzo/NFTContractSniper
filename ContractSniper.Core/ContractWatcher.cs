using ContractSniper.Core.Interfaces;
using ContractSniper.Core.Models;
using Nethereum.Web3;
using Nethereum.Util;
using Nethereum.Hex.HexTypes;

namespace ContractSniper.Core
{
    internal class ContractWatcher : IContractWatcher
    {
        private readonly WatcherInput _Input;
        private readonly IWeb3 _Web3;
        private readonly ILoggingService _Logger;

        public ContractWatcher(WatcherInput input, IWeb3 web3, ILoggingService logger)
        {
            _Input = input;
            _Web3 = web3;
            _Logger = logger;
        }

        public async Task StartWatching(CancellationToken cancellationToken = default)
        {
            _Logger.WriteLine("Getting wallet address from private key");
            var address = _Web3.Eth.TransactionManager.Account.Address;

            _Logger.WriteLine("Loading contract ABI at contract address");
            var contract = _Web3.Eth.GetContract(_Input.ContractABI, _Input.ContractAddress);
            if (contract == null) throw new Exception("Contract not found");

            _Logger.WriteLine("Getting Live and Mint functions");
            var isLiveFunction = contract.GetFunction(_Input.LivePulse);
            if (isLiveFunction == null) throw new Exception("Live function not found on contract");
            var mintFunction = contract.GetFunction(_Input.MintFunction);
            if (mintFunction == null) throw new Exception("Mint function not found on contract");

            var costToMint = CalculateCostToMint();
            _Logger.WriteLine($"Will cost {UnitConversion.Convert.FromWei(costToMint.Value, UnitConversion.EthUnit.Ether)} ETH to mint, plus gas");
            await GetCurrentGasPriceForTransaction();

            while (true)
            {
                if (cancellationToken.IsCancellationRequested) break;
                await Task.Delay(2000);
                var isLiveResponse = await isLiveFunction.CallAsync<bool>();
                if (isLiveResponse)
                {
                    _Logger.WriteLine("Minting is live, estimating gas...");

                    var gasForFunction = await mintFunction.EstimateGasAsync(address, null, costToMint, _Input.NumberToMint);
                    _Logger.WriteLine($"Mint function is estimated to use {gasForFunction.Value} gas");

                    var gasPriceWei = await GetCurrentGasPriceForTransaction();

                    _Logger.WriteLine($"Submitting Transaction... Wait for response...");
                    var transaction = await mintFunction.SendTransactionAndWaitForReceiptAsync(
                        from: address,
                        gas: gasForFunction, 
                        gasPrice: gasPriceWei,
                        value: costToMint,
                        functionInput: _Input.NumberToMint);
                    if (transaction.HasErrors() ?? true) throw new Exception($"Transaction failed: {transaction.TransactionHash}");
                    _Logger.WriteLine($"Transaction Created: {transaction.TransactionHash}");
                    break;
                }

                _Logger.WriteLine("Not live yet, checking again in 2 sec");
            }      
        }

        private HexBigInteger CalculateCostToMint()
        {
            var pricePer = UnitConversion.Convert.ToWei(BigDecimal.Parse(_Input.CostToMint), UnitConversion.EthUnit.Ether);
            var totalCost = pricePer * _Input.NumberToMint;
            return totalCost.ToHexBigInteger();
        }

        private async Task<HexBigInteger> GetCurrentGasPriceForTransaction()
        {
            var gasPriceWei = await _Web3.Eth.GasPrice.SendRequestAsync();
            _Logger.WriteLine($"Current gas price is {UnitConversion.Convert.FromWei(gasPriceWei.Value, UnitConversion.EthUnit.Gwei)} gwei");
            gasPriceWei = ((gasPriceWei.Value * _Input.PercentMoreGas / 100) + gasPriceWei.Value).ToHexBigInteger();
            _Logger.WriteLine($"Transaction will use the {_Input.PercentMoreGas}% more gas - {UnitConversion.Convert.FromWei(gasPriceWei.Value, UnitConversion.EthUnit.Gwei)} gwei");
            return gasPriceWei;
        }
    }
}
