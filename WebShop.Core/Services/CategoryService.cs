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
        public async Task<IEnumerable<CategoryQueryModel>> GetAllCategory()
        {
            return await repo.AllReadonly<Category>()
                .ProjectTo<CategoryQueryModel>(mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
