using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Core.Contracts;
using WebShop.Core.Models.Products;
using WebShop.Infrastructure.Data.Entities;
using WebShop.Infrastructure.Repository;

namespace WebShop.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository repo;
        private readonly IMapper mapper;

        public ProductService(IRepository _repo, IMapper _mapper)
        {
            repo= _repo;
            mapper= _mapper;
        }
        public async Task AddNewProduct(ProductModel model)
        {
            //var sanitizor = new HtmlSanitizer();
            var product = new Product
            {
                Title = model.Title,
                Price = model.Price,
                MainImage = model.MainImage,
                CreatedDate = DateTime.Now,
                SubCategoryId = model.SubCategoryId,
            };
            await repo.AddAsync(product);
            await repo.SaveChangesAsync();

            var productId = await repo.All<Product>().FirstOrDefaultAsync(p => p.Title == model.Title);
            var images = model.Images.Split(" ");
            foreach (var image in images)
            {
                var img = new Image()
                {
                    Extension = image,
                    ProductId = productId.Id,
                    CreatedDate= DateTime.Now,
                };
                await repo.AddAsync(img);
            }

            var descriptions = model.Description.Split("/");

            foreach (var des in descriptions)
            {
                var description = new ProductDescription()
                {
                    Description = des,
                    ProductId = productId.Id,
                    CreatedDate= DateTime.Now,                    
                };
                await repo.AddAsync(description);
            }
            await repo.SaveChangesAsync();
        }

        public async Task<IEnumerable<SubCategory>> GetSubCategories()
        {
            return await repo.All<SubCategory>().ToListAsync();
        }

        public async Task<IEnumerable<ProductQueryModel>> AllProducts()
        {
                return await repo.AllReadonly<Product>().Where(g => g.IsDeleted == false)
                    .ProjectTo<ProductQueryModel>(mapper.ConfigurationProvider)
                    .ToListAsync();           
        }
    }
}
