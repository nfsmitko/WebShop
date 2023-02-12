using WebShop.Core.Models.Categories;

namespace WebShop.Core.Contracts
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryQueryModel>> GetAllCategory();

    }
}
