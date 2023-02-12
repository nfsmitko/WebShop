using WebShop.Core.Models.Products;
using WebShop.Infrastructure.Data.Entities;

namespace WebShop.Core.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductQueryModel>> AllProducts();

        Task<IEnumerable<SubCategory>> GetSubCategories();

        Task AddNewProduct(ProductModel model);
    }
}
