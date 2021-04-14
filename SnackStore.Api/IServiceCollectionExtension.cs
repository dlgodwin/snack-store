using System;
using Microsoft.Extensions.DependencyInjection;
using SnackStore.Services;

namespace SnackStore.Api
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddInternalServices(this IServiceCollection services)
        {
            services.AddTransient<IProductService, ProductService>();
            return services;
        }
    }
}
