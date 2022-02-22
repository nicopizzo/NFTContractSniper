using ContractSniper.Core.Models;

namespace ContractSniper.Core.Interfaces
{
    public interface IContractWatcherFactory
    {
        IContractWatcher CreateContractWatcher(WatcherInput input, ILoggingService loggingService);
    }
}
