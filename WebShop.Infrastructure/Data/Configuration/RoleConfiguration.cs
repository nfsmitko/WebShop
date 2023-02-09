using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebShop.Infrastructure.Data.Entities;

namespace WebShop.Infrastructure.Data.Configuration
{
    internal class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(CreateUserRole());
        }

        private List<Role> CreateUserRole()
        {
            var roles = new List<Role>()
            {
                new Role()
                {
                    Id = "b054a395-079b-452e-a440-68231c633323",
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    CreatedOn = DateTime.Now,
                },
                new Role()
                {
                    Id = "32644b40-8958-4f7d-a0c1-5eaa91ae497e",
                    Name = "User",
                    NormalizedName = "USER",
                    CreatedOn = DateTime.Now,
                },
            };
            return roles;
        }
    }
}
