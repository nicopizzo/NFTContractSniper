using ContractSniper.Core.Interfaces;
using ContractSniper.Core.Models;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;

namespace ContractSniper.Core.Services
{
    internal class ContractWatcherFactory : IContractWatcherFactory
    {
        public IContractWatcher CreateContractWatcher(WatcherInput input, ILoggingService loggingService)
        {
            var account = new Account(input.PrivateKey, 1);
            var web3 = new Web3(account, "https://mainnet.infura.io/v3/9aa3d95b3bc440fa88ea12eaa4456161");
            return new ContractWatcher(input, web3, loggingService);
        }
    }
}
