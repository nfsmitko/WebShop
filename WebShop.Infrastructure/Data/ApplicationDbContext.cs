using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebShop.Infrastructure.Data.Configuration;
using WebShop.Infrastructure.Data.Entities;

namespace WebShop.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<SubCategory> SubCategories { get; set; } = null!;

        public DbSet<Product> Products { get; set; } = null!;

        public DbSet<Image> Images { get; set; } = null!;

        public DbSet<ProductDescription> ProductDescriptions { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserProducts>()
                .HasKey(x => new { x.UserId, x.ProductId});

            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new SubCategoryConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());


            base.OnModelCreating(builder);
        }
    }
}