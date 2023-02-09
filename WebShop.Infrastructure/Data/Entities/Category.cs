using System.ComponentModel.DataAnnotations;
using static WebShop.Infrastructure.Data.Common.DataValidationConstants.Category;

namespace WebShop.Infrastructure.Data.Entities
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(MaxCategoryNameLenght)]
        public string Name { get; set; } = null!;

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public ICollection<SubCategory> SubCategories { get; set;} = new List<SubCategory>();
    }
}
