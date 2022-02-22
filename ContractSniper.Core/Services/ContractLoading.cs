using ContractSniper.Core.Interfaces;
using Nethereum.ABI.ABIDeserialisation;
using Nethereum.ABI.Model;

namespace ContractSniper.Core.Services
{
    internal class ContractLoading : IContractLoading
    {
        public ContractABI GetABI(string abi)
        {
            var seralizer = new ABIJsonDeserialiser();
            return seralizer.DeserialiseContract(abi);
        }
    }
}
