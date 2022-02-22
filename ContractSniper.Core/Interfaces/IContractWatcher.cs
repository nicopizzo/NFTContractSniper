using Nethereum.ABI.Model;

namespace ContractSniper.Core.Interfaces
{
    public interface IContractWatcher
    {
        Task StartWatching(CancellationToken cancellationToken = default);
    }
}
