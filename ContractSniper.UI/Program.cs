using Microsoft.Extensions.DependencyInjection;
using ContractSniper.Core;
using ContractSniper.Core.Interfaces;
using ContractSniper.UI.Services;

namespace ContractSniper.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IServiceProvider serviceProvider = new ServiceCollection()
                .AddContractWatcher()
                .AddSingleton<ILoggingServiceFactory, LoggingServiceFactory>()
                .BuildServiceProvider();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new ContractSniper(
                serviceProvider.GetRequiredService<IContractWatcherFactory>(),
                serviceProvider.GetRequiredService<IContractLoading>(),
                serviceProvider.GetRequiredService<ILoggingServiceFactory>()));
        }
    }
}