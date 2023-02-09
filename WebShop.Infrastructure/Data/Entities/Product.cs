using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static WebShop.Infrastructure.Data.Common.DataValidationConstants.Poduct;

namespace WebShop.Infrastructure.Data.Entities
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(MaxTitleLenght)]
        public string Title { get; set; }

        [Required]
        [StringLength(MaxDescriptionLenght)]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public Guid SubCategoryId { get; set; }

        [Required]
        [ForeignKey(nameof(SubCategoryId))]
        public virtual SubCategory SubCategory { get; set; } = null!;

        public ICollection<UserProducts> UserProducts { get; set; } = new List<UserProducts>();

        public ICollection<Image> Images { get;set; } = new List<Image>();

    }
}
