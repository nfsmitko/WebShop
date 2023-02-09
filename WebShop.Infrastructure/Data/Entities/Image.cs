using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WebShop.Infrastructure.Data.Common.DataValidationConstants;

namespace WebShop.Infrastructure.Data.Entities
{
    public class Image
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Extension { get; set; } = null!;

        public Guid ProductId { get; set; }

        [Required]
        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; } = null!;

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
