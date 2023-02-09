using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static WebShop.Infrastructure.Data.Common.DataValidationConstants.User;

namespace WebShop.Infrastructure.Data.Entities
{
    public class User : IdentityUser
    {
        [Required]
        [StringLength(MaxUserFirstNameLenght)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(MaxUserLastNameLenght)]
        public string LastName { get; set; } = null!;

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime? ModifiedOn { get; set; }

        public ICollection<UserProducts> FavoriteProducts { get; set; } = new List<UserProducts>();

    }
}
