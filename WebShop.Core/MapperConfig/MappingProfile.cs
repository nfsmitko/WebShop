using AutoMapper;
using WebShop.Core.Models.Categories;
using WebShop.Core.Models.SubCategoies;
using WebShop.Infrastructure.Data.Entities;

namespace WebShop.Core.MapperConfig
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            //Category Mapping
            this.CreateMap<Category, CategoryQueryModel>();

            //SubCategory Mapping
            this.CreateMap<SubCategory, SubCategoryQueryModel>();
        }

    }
}
