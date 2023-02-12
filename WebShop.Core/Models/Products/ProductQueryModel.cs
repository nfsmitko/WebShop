using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Infrastructure.Data.Entities;

namespace WebShop.Core.Models.Products
{
    public class ProductQueryModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Title { get; set; } = null!;

        public decimal Price { get; set; }

        public string MainImage { get; set; } = null!;

        public string CategoryName { get; set; }

        public ICollection<ProductDescription> ProductDescriptions { get; set; } = new List<ProductDescription>();

        public ICollection<Image> Images { get; set; } = new List<Image>();
    }
}
