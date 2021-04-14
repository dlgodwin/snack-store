using System;
using Microsoft.Extensions.DependencyInjection;
using SnackStore.Domain.Contexts;
using SnackStore.Domain.Repositories;

namespace SnackStore.Services
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<ISnackStoreContext, SnackStoreContext>();
            return services;
        }
    }
}
