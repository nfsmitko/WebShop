using WebShop.Infrastructure.Data.Entities;

namespace WebShop.Core.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);

        void Save();
    }
}
