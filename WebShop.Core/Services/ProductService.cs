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
            var product = new Product
            {
                Title = model.Title,
                Price = model.Price,
                MainImage = model.MainImage,
                CreatedDate = DateTime.Now,
                SubCategoryId = model.SubCategoryId,
            };
            var images = model.Images.Split(" ");
            foreach (var image in images)
            {
                var img = new Image()
                {
                    Extension = image,
                    CreatedDate= DateTime.Now,
                };
                product.Images.Add(img);
            }

            foreach (var des in model.Description)
            {
                var description = new ProductDescription()
                {
                    Title = des.Title,
                    Description = des.Description,
                    CreatedDate = DateTime.Now,
                };
                product.ProductDescriptions.Add(description);
            }
            await repo.AddAsync(product);
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
