using System.ComponentModel.DataAnnotations;
using static WebShop.Infrastructure.Data.Common.DataValidationConstants;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.Infrastructure.Data.Entities
{
    public class ProductDescription
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string Title { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        public Guid ProductId { get; set; }

        [Required]
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;
    }
}
