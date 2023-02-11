using WebShop.Core.Repository.IRepository;
using WebShop.Data;
using WebShop.Infrastructure.Data.Entities;

namespace WebShop.Core.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext db;

        public CategoryRepository(ApplicationDbContext _db) : base(_db)
        {
            db = _db;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Category category)
        {
            db.Update(category);
        }
    }
}
