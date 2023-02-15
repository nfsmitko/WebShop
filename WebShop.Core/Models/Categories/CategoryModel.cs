using System.ComponentModel.DataAnnotations;
using WebShop.Core.Models.SubCategoies;

namespace WebShop.Core.Models.Categories
{
    public class CategoryModel
    {
        [Required]
        public string Name { get; set; } = null!;

        public ICollection<SubCategoryModel> SubCategories { get; set; } = new List<SubCategoryModel>();
    }
}
