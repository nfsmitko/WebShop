using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebShop.Infrastructure.Data.Entities;

namespace WebShop.Infrastructure.Data.Configuration
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(CreateCategories());
        }

        private List<Category> CreateCategories()
        {
            List<Category> categories = new List<Category>
            {
                new Category
                {
                    Id = Guid.Parse("37aadfc2-179a-4e6e-a8aa-0f09ce0dc36c"),
                    Name = "Laptops"
                },
                new Category
                {
                   Id = Guid.Parse("796209de-79b4-4ca5-9b08-f2c4306ff387"),
                    Name = "Computers"
                },
                new Category
                {
                    Id = Guid.Parse("7858db3b-3299-493a-9d87-3830b4f603bc"),
                    Name = "Accessories"
                },
                new Category
                {
                    Id = Guid.Parse("0ddb8ef0-0a46-4569-a7a1-9c76fcaee655"),
                    Name = "Smartphone"
                },
                new Category
                {
                    Id = Guid.Parse("a211c484-8fb5-4f18-a87e-b2e30101fc67"),
                    Name = "Tablets"
                },
                new Category
                {
                    Id = Guid.Parse("00b8b863-7f19-4eb5-8460-c68417db3496"),
                    Name = "Components"
                },
                new Category
                {
                    Id = Guid.Parse("56c40de8-294a-453e-82d1-5d055bed3e6b"),
                    Name = "Peripherals"
                },
                new Category
                {
                    Id = Guid.Parse("109ccb1d-0a98-4f0f-bbd3-23f2d38251e6"),
                    Name = "Game zone"
                }
            };

            return categories;
        }
    }
}
