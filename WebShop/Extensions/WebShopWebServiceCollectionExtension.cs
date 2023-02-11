using WebShop.Core.Repository;
using WebShop.Core.Repository.IRepository;

namespace WebShop.Extensions
{
    public static class WebShopWebServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            return services;
        }
    }
}
