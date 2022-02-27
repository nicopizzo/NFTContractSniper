using ContractSniper.Core.Interfaces;
using ContractSniper.Core.Models;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;

namespace ContractSniper.Core.Services
{
    internal class ContractWatcherFactory : IContractWatcherFactory
    {
        public IContractWatcher CreateContractWatcher(WatcherInput input, ILoggingService loggingService, EthNetwork network)
        {
            var account = new Account(input.PrivateKey, network.Value);
            var web3 = new Web3(account, network.NodeEndpoint);
            return new ContractWatcher(input, web3, loggingService);
        }
    }
}
