using ContractSniper.UI.Services;
using ContractSniper.Core.Interfaces;
using ContractSniper.Core.Models;
using Nethereum.ABI.Model;

namespace ContractSniper.UI
{
    public partial class ContractSniper : Form
    {
        private readonly IContractWatcherFactory _ContractWatcherFactory;
        private readonly IContractLoading _ContractLoading;
        private readonly ILoggingService _Logger;
        private CancellationTokenSource? _CancellationTokenSource;

        internal ContractSniper(IContractWatcherFactory contractWatcherFactory, IContractLoading contractLoading, ILoggingServiceFactory loggingServiceFactory)
        {
            InitializeComponent();
            _Logger = loggingServiceFactory.GetLoggingService(txt_log);
            _ContractWatcherFactory = contractWatcherFactory;
            _ContractLoading = contractLoading;
            Init();
        }

        private void Init()
        {
            cmb_Network.Items.Clear();
            foreach(var network in EthNetwork.List)
            {
                cmb_Network.Items.Add(network);
            }
            cmb_Network.SelectedIndex = 0;
        }

        private async void btn_StartWatching_Click(object sender, EventArgs e)
        {
            _CancellationTokenSource = new CancellationTokenSource();
            if (ValidateWatching())
            {
                _Logger.WriteLine("Creating Contract Watcher");
                try
                {
                    var input = CreateWatcherInput();
                    var watcher = _ContractWatcherFactory.CreateContractWatcher(input, _Logger, (EthNetwork)cmb_Network.SelectedItem);
                    btn_StopWatching.Enabled = true;
                    await watcher.StartWatching(_CancellationTokenSource.Token);
                }
                catch (Exception ex)
                {
                    _Logger.WriteLine(ex.ToString());
                    MessageBox.Show($"Failed durring watch: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    btn_StopWatching.Enabled = false;
                    _CancellationTokenSource?.Dispose();
                }
            }
        }

        private void btn_StopWatching_Click(object sender, EventArgs e)
        {
            if (_CancellationTokenSource != null && !_CancellationTokenSource.IsCancellationRequested)
            {
                _Logger.WriteLine("Canceling...");
                _CancellationTokenSource?.Cancel();
                _CancellationTokenSource?.Dispose();
            }
        }

        private WatcherInput CreateWatcherInput()
        {
            var input = new WatcherInput()
            {
                PrivateKey = txt_privatekey.Text,
                ContractAddress = txt_contractAddress.Text,
                ContractABI = txt_contractABI.Text,
                LivePulse = cmb_IsLive.Text,
                MintFunction = cmb_Mint.Text,
                NumberToMint = int.Parse(txt_NoToMint.Text),
                CostToMint = txt_mintCost.Text,
                RetryOnFailedEstimation = chk_RetryEstimateFailure.Checked
            };

            if(int.TryParse(txt_GasPrice.Text, out int p)) input.GasPrice = p;
            if (int.TryParse(txt_MoreGas.Text, out int m)) input.PercentMoreGas = m;

            return input;
        }

        private bool ValidateWatching()
        {
            _Logger.WriteLine("Validating input parameters");
            if (string.IsNullOrEmpty(txt_contractAddress.Text))
            {
                MessageBox.Show("Contract address missing");
                return false;
            }
            if (string.IsNullOrEmpty(txt_privatekey.Text))
            {
                MessageBox.Show("Private Key missing");
                return false;
            }
            if (string.IsNullOrEmpty(txt_contractABI.Text))
            {
                MessageBox.Show("Contract ABI missing");
                return false;
            }
            if (string.IsNullOrEmpty(cmb_IsLive.Text))
            {
                MessageBox.Show("Is Live check endpoint missing");
                return false;
            }
            if (string.IsNullOrEmpty(cmb_Mint.Text))
            {
                MessageBox.Show("Mint endpoint missing");
                return false;
            }
            if (string.IsNullOrEmpty(txt_NoToMint.Text) && !int.TryParse(txt_NoToMint.Text, out _))
            {
                MessageBox.Show("Number to mint endpoint missing or invalid");
                return false;
            }
            if (string.IsNullOrEmpty(txt_mintCost.Text) && !double.TryParse(txt_mintCost.Text, out _))
            {
                MessageBox.Show("Mint cost missing or invalid");
                return false;
            }

            return true;
        }

        private void btn_LoadABI_Click(object sender, EventArgs e)
        {
            try
            {
                _Logger.WriteLine("Reading Contract ABI");
                var contractABI = _ContractLoading.GetABI(txt_contractABI.Text);
                PopulateFromABI(contractABI);
                MessageBox.Show("Contract ABI Loaded: Potential functions found");
            }
            catch
            {
                MessageBox.Show("Unable to parse ABI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateFromABI(ContractABI contractABI)
        {
            cmb_IsLive.Items.Clear();
            var possibleIsLive = contractABI.Functions.Where(f => f.OutputParameters.Count() == 1 && 
                                                    string.Equals(f.OutputParameters[0].Type, "bool", StringComparison.CurrentCultureIgnoreCase));

            foreach(var live in possibleIsLive) cmb_IsLive.Items.Add(live.Name);


            cmb_Mint.Items.Clear();
            var possibleMint = contractABI.Functions.Where(f => f.InputParameters.Count() == 1 &&
                                        f.InputParameters[0].Type.Contains("int", StringComparison.CurrentCultureIgnoreCase));

            foreach (var mint in possibleMint) cmb_Mint.Items.Add(mint.Name);
        }

        private void txt_log_TextChanged(object sender, EventArgs e)
        {
            txt_log.SelectionStart = txt_log.Text.Length;
            txt_log.ScrollToCaret();
        }
    }
}