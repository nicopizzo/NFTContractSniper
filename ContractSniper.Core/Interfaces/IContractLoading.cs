using Nethereum.ABI.Model;

namespace ContractSniper.Core.Interfaces
{
    public interface IContractLoading
    {
        ContractABI GetABI(string abi);
    }
}
