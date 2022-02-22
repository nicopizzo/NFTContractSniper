namespace ContractSniper.Core.Models
{
    public class WatcherInput
    {
        public string? PrivateKey { get; set; }
        public string? ContractAddress { get; set; }
        public string? ContractABI { get; set; }
        public int NumberToMint { get; set; }
        public string? CostToMint { get; set; }
        public string? LivePulse { get; set; }
        public string? MintFunction { get; set; }
        public int PercentMoreGas { get; set; }
    }
}
