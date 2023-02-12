using System.ComponentModel.DataAnnotations;
using WebShop.Infrastructure.Data.Entities;

namespace WebShop.Core.Models.Products
{
    public class ProductModel
    {
        [Required]
        public string Title { get; set; } = null!;

        [Required]
        public decimal Price { get; set; }

        [Required] 
        public string Description { get; set; }

        [Required]
        public string MainImage { get; set; } = null!;

        public string Images { get; set; }

        [Required]
        public Guid SubCategoryId { get; set; }

        public IEnumerable<SubCategory> SubCategoies { get; set; } = new List<SubCategory>();
    }
}
