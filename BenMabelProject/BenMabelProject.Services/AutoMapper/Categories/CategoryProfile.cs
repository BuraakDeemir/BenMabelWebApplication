using AutoMapper;
using BenMabelProject.Entity.DtoS.Category;
using BenMabelProject.Entity.Entities;

namespace BenMabelProject.Services.AutoMapper.Categories
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
        }
    }
}
