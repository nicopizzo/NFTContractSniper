using ContractSniper.Core.Interfaces;

namespace ContractSniper.UI.Services
{
    internal class LoggingService : ILoggingService
    {
        private readonly Control _control;

        public LoggingService(Control control)
        {
            _control = control;
        }

        public void WriteLine(string message)
        {
            _control.Text += message + Environment.NewLine;
        }
    }
}
