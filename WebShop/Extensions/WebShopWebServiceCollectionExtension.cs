using WebShop.Core.Contracts;
using WebShop.Core.Services;
using WebShop.Infrastructure.Repository;

namespace WebShop.Extensions
{
    public static class WebShopWebServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<ICategoryService, CategoryService>();

            return services;
        }
    }
}
