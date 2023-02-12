using AutoMapper.QueryableExtensions;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Core.Contracts;
using WebShop.Core.Models.Categories;
using WebShop.Core.Models.SubCategoies;
using WebShop.Infrastructure.Repository;
using WebShop.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;

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
        public async Task<IEnumerable<SubCategoryQueryModel>> GetAllSubCategory(Guid id)
        {
            return await repo.AllReadonly<SubCategory>().Where(x=>x.CategoryId == id)
                .ProjectTo<SubCategoryQueryModel>(mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
