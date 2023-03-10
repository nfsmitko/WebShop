using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using WebShop.Core.Contracts;
using WebShop.Core.Models.SubCategoies;
using WebShop.Infrastructure.Data.Entities;
using WebShop.Infrastructure.Repository;

namespace WebShop.Core.Services
{
    public class SubCategoryService : ISubCategoryService
    {
        private readonly IRepository repo;
        private readonly IMapper mapper;

        public SubCategoryService(IRepository _repo, IMapper _mapper)
        {
            repo = _repo;
            mapper = _mapper;
        }

        public async Task<Guid> DeleteSubCategory(Guid id)
        {
            var subCategory = await repo.GetByIdAsync<SubCategory>(id);

            subCategory.IsDeleted= true;

            subCategory.DeletedOn = DateTime.Now;

            repo.Update(subCategory);

            await repo.SaveChangesAsync();

            return subCategory.CategoryId;
        }

        public async Task<IEnumerable<SubCategoryQueryModel>> GetAllSubCategory(Guid id)
        {
            return await repo.AllReadonly<SubCategory>().Where(x=>x.CategoryId == id && x.IsDeleted == false).OrderBy(sb => sb.Name)
                .ProjectTo<SubCategoryQueryModel>(mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
