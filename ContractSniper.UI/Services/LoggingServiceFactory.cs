using ContractSniper.Core.Interfaces;

namespace ContractSniper.UI.Services
{
    internal interface ILoggingServiceFactory
    {
        ILoggingService GetLoggingService(Control control);
    }

    internal class LoggingServiceFactory : ILoggingServiceFactory
    {
        public ILoggingService GetLoggingService(Control control)
        {
            return new LoggingService(control);
        }
    }
}
