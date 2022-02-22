using ContractSniper.Core.Interfaces;
using ContractSniper.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ContractSniper.Core
{
    public static class ContractWatcherConfig
    {
        public static IServiceCollection AddContractWatcher(this IServiceCollection services)
        {
            services.AddSingleton<IContractLoading, ContractLoading>();
            services.AddSingleton<IContractWatcherFactory, ContractWatcherFactory>();
            services.AddSingleton<IContractWatcher, ContractWatcher>();
            return services;
        }
    }
}
