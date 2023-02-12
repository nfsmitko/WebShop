using AutoMapper;
using WebShop.Core.Models.Categories;
using WebShop.Infrastructure.Data.Entities;

namespace WebShop.Core.MapperConfig
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            //Category Mapping
            this.CreateMap<Category, CategoryQueryModel>();
        }

    }
}
