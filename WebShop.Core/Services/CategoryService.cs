using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using WebShop.Core.Contracts;
using WebShop.Core.Models.Categories;
using WebShop.Infrastructure.Data.Entities;
using WebShop.Infrastructure.Repository;

namespace WebShop.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository repo;
        private readonly IMapper mapper;

        public CategoryService(IRepository _repo, IMapper _mapper)
        {
            repo = _repo;
            mapper = _mapper;
        }

        public async Task AddNewCategory(CategoryModel model)
        {
            var category = new Category
            {
                Name = model.Name,
                CreatedDate = DateTime.Now,
            };

            foreach (var subCategoryInput in model.SubCategories)
            {
                var subCategory = new SubCategory
                {
                    Name = subCategoryInput.Name,
                    CreatedDate = DateTime.Now,
                };

                category.SubCategories.Add(subCategory);
            }

            await repo.AddAsync(category);

            await repo.SaveChangesAsync();
        }

        public async Task<IEnumerable<CategoryQueryModel>> GetAllCategory()
        {
            return await repo.AllReadonly<Category>().Where(c => c.IsDeleted == false).OrderBy(c => c.Name)
                .ProjectTo<CategoryQueryModel>(mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
