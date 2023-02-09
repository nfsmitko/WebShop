using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebShop.Infrastructure.Data.Entities;

namespace WebShop.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<SubCategory> SubCategories { get; set; } = null!;

        public DbSet<Product> Products { get; set; } = null!;

        public DbSet<Image> Images { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserProducts>()
                .HasKey(x => new { x.UserId, x.ProductId});

            base.OnModelCreating(builder);
        }
    }
}