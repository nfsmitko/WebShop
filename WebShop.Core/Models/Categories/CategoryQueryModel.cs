using WebShop.Infrastructure.Data.Entities;

namespace WebShop.Core.Models.Categories
{
    public class CategoryQueryModel
    {  
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public ICollection<SubCategory> SubCategories { get; set; } = new List<SubCategory>();
    }
}
