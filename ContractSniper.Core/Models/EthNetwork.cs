using Ardalis.SmartEnum;

namespace ContractSniper.Core.Models
{
    public abstract class EthNetwork : SmartEnum<EthNetwork>
    {
        public static readonly EthNetwork Mainnet = new MainnetNetwork();
        public static readonly EthNetwork Rinkbey = new RinkebyNetwork();

        public abstract string NodeEndpoint { get; }

        private EthNetwork(string name, int value) : base(name, value)
        {
        }

        // Implementations
        private sealed class MainnetNetwork : EthNetwork
        {
            public MainnetNetwork() : base("Mainnet", 1)
            {
            }


            public override string NodeEndpoint => "https://mainnet.infura.io/v3/9aa3d95b3bc440fa88ea12eaa4456161";
        }

        private sealed class RinkebyNetwork : EthNetwork
        {
            public RinkebyNetwork() : base("Rinkeby", 4)
            {
            }

            public override string NodeEndpoint => "https://rinkeby.infura.io/v3/9aa3d95b3bc440fa88ea12eaa4456161";
        }
    }
}
