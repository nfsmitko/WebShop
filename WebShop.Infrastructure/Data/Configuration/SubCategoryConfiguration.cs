using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebShop.Infrastructure.Data.Entities;

namespace WebShop.Infrastructure.Data.Configuration
{
    internal class SubCategoryConfiguration : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            builder.HasData(CreateUserRole());
        }

        private List<SubCategory> CreateUserRole()
        {
            var subCategory = new List<SubCategory>()
            {
                new SubCategory()
                {
                    Id = Guid.Parse("ce674d7b-013b-4efc-a5d1-0951b488ddeb"),
                    Name = "Laptops",
                    CategoryId = Guid.Parse("37aadfc2-179a-4e6e-a8aa-0f09ce0dc36c")
                },
                new SubCategory()
                {
                    Id = Guid.Parse("dfa0476d-9531-4865-914b-f1551f473129"),
                    Name = "Gaming Laptops",
                    CategoryId = Guid.Parse("37aadfc2-179a-4e6e-a8aa-0f09ce0dc36c")
                },
                new SubCategory()
                {
                    Id = Guid.Parse("1d38b388-5eb0-4bb3-8279-c18018b36428"),
                    Name = "Computers",
                    CategoryId = Guid.Parse("796209de-79b4-4ca5-9b08-f2c4306ff387")
                },
                new SubCategory()
                {
                    Id = Guid.Parse("be9e90b4-c00d-451b-94ea-ad1b55d2c9f9"),
                    Name = "Gaming Computers",
                    CategoryId = Guid.Parse("796209de-79b4-4ca5-9b08-f2c4306ff387")
                },
                new SubCategory()
                {
                    Id = Guid.Parse("c46cd764-c7bb-4f2f-ba25-ac4c110958bb"),
                    Name = "Laptop Batteries",
                    CategoryId = Guid.Parse("7858db3b-3299-493a-9d87-3830b4f603bc")
                },
                new SubCategory()
                {
                    Id = Guid.Parse("cce85b6f-b9a7-4be4-a0af-73ed8ec18cc7"),
                    Name = "Laptop Bags",
                    CategoryId = Guid.Parse("7858db3b-3299-493a-9d87-3830b4f603bc")
                },
                new SubCategory()
                {
                    Id = Guid.Parse("1a6b32fb-55f5-4231-a1d7-b5cf564cc715"),
                    Name = "Smartphones",
                    CategoryId = Guid.Parse("0ddb8ef0-0a46-4569-a7a1-9c76fcaee655")
                },
                new SubCategory()
                {
                    Id = Guid.Parse("9c5285d2-615b-4666-9319-e3817a572ca5"),
                    Name = "Smartphones Apple",
                    CategoryId = Guid.Parse("0ddb8ef0-0a46-4569-a7a1-9c76fcaee655")
                },
                new SubCategory()
                {
                    Id = Guid.Parse("f0adbb23-4d6a-45b8-8056-1695948c63a4"),
                    Name = "Tablets",
                    CategoryId = Guid.Parse("a211c484-8fb5-4f18-a87e-b2e30101fc67")
                },
                new SubCategory()
                {
                    Id = Guid.Parse("0e0599a4-2854-451e-bc19-69c5e5a7eca0"),
                    Name = "Graphics Tablets",
                    CategoryId = Guid.Parse("a211c484-8fb5-4f18-a87e-b2e30101fc67")
                },
                new SubCategory()
                {
                    Id = Guid.Parse("506449d5-e28b-43be-9882-4739211dced9"),
                    Name = "SSD",
                    CategoryId = Guid.Parse("00b8b863-7f19-4eb5-8460-c68417db3496")
                },
                new SubCategory()
                {
                    Id = Guid.Parse("a7276329-f79a-42e1-a2c3-8aa64fc943bd"),
                    Name = "HDD",
                    CategoryId = Guid.Parse("00b8b863-7f19-4eb5-8460-c68417db3496")
                },
                new SubCategory()
                {
                    Id = Guid.Parse("42041daf-22b3-40b7-9d8b-a9723518abaf"),
                    Name = "Computer Processor",
                    CategoryId = Guid.Parse("00b8b863-7f19-4eb5-8460-c68417db3496")
                },
                new SubCategory()
                {
                    Id = Guid.Parse("ed8afc98-25ff-4b22-a934-e5e19c2b405b"),
                    Name = "Video Card",
                    CategoryId = Guid.Parse("00b8b863-7f19-4eb5-8460-c68417db3496")
                },
                new SubCategory()
                {
                    Id = Guid.Parse("840bee94-6ed7-40ee-a7bc-2fa09c0726c9"),
                    Name = "Memory",
                    CategoryId = Guid.Parse("00b8b863-7f19-4eb5-8460-c68417db3496")
                },
                new SubCategory()
                {
                    Id = Guid.Parse("b118ffb5-e5ea-4de4-94ed-d399b916087b"),
                    Name = "Keyboard",
                    CategoryId = Guid.Parse("56c40de8-294a-453e-82d1-5d055bed3e6b")
                },
                new SubCategory()
                {
                    Id = Guid.Parse("e498e56f-d873-405e-b983-dc48e2309b06"),
                    Name = "Mause",
                    CategoryId = Guid.Parse("56c40de8-294a-453e-82d1-5d055bed3e6b")
                },
                new SubCategory()
                {
                    Id = Guid.Parse("9dfcb19f-3030-43b0-b82e-6f116826f274"),
                    Name = "Headphones",
                    CategoryId = Guid.Parse("56c40de8-294a-453e-82d1-5d055bed3e6b")
                },
                new SubCategory()
                {
                    Id = Guid.Parse("3c1d177f-f171-4a09-a86d-5ea6f0f818c6"),
                    Name = "Web Camera",
                    CategoryId = Guid.Parse("56c40de8-294a-453e-82d1-5d055bed3e6b")
                },
                new SubCategory()
                {
                    Id = Guid.Parse("269085b4-e4cc-4dd4-bad0-7eac9fea98ac"),
                    Name = "Monitor",
                    CategoryId = Guid.Parse("56c40de8-294a-453e-82d1-5d055bed3e6b")
                },
                new SubCategory()
                {
                    Id = Guid.Parse("b262e059-66bc-40ec-8cae-5693a8ae2d90"),
                    Name = "Gaming Keyboard",
                    CategoryId = Guid.Parse("109ccb1d-0a98-4f0f-bbd3-23f2d38251e6")
                },
                new SubCategory()
                {
                    Id = Guid.Parse("c28b04e4-255b-4ca7-9110-55eb575fef55"),
                    Name = "Gaming Mause",
                    CategoryId = Guid.Parse("109ccb1d-0a98-4f0f-bbd3-23f2d38251e6")
                },
                new SubCategory()
                {
                    Id = Guid.Parse("437b2ac1-88f4-461c-a929-c2194a544950"),
                    Name = "Gaming Headphones",
                    CategoryId = Guid.Parse("109ccb1d-0a98-4f0f-bbd3-23f2d38251e6")
                },
                new SubCategory()
                {
                    Id = Guid.Parse("180538ac-f70f-498f-9a83-454ef8a85a73"),
                    Name = "Gaming Monitor",
                    CategoryId = Guid.Parse("109ccb1d-0a98-4f0f-bbd3-23f2d38251e6")
                }
            };
            return subCategory;
        }
    }
}
