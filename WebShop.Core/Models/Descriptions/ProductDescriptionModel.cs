using System.ComponentModel.DataAnnotations;

namespace WebShop.Core.Models.Descriptions
{
    public class ProductDescriptionModel
    {
        [Required]
        public string Title { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;
    }
}
