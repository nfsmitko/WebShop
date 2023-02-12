using WebShop.Infrastructure.Data.Entities;

namespace WebShop.Core.Models.SubCategoies
{
    public class SubCategoryQueryModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
