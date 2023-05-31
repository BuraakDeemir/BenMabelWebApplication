using AutoMapper;
using BenMabelProject.Entity.DtoS.Products;
using BenMabelProject.Entity.Entities;

namespace BenMabelProject.Services.AutoMapper.Products
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductAddDto>().ReverseMap();
            CreateMap<Product, ProductDetailDto>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Product, ProductUpdateDto>().ReverseMap();
            CreateMap<ProductPrice, ProductDto>().ReverseMap();
        }
    }
}
