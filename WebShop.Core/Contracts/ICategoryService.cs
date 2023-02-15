using WebShop.Core.Models.Categories;
using WebShop.Core.Models.Products;

namespace WebShop.Core.Contracts
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryQueryModel>> GetAllCategory();

        Task AddNewCategory(CategoryModel model);
    }
}
