using WebShop.Core.Models.SubCategoies;

namespace WebShop.Core.Contracts
{
    public interface ISubCategoryService
    {
        Task<IEnumerable<SubCategoryQueryModel>> GetAllSubCategory(Guid id);

        Task<Guid> DeleteSubCategory(Guid id);
    }
}
