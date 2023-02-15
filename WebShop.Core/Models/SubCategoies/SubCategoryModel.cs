using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Core.Models.SubCategoies
{
    public class SubCategoryModel
    {
        [Required]
        public string Name { get; set; } = null!;
    }
}
