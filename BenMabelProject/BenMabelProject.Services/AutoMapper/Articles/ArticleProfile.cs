using AutoMapper;
using BenMabelProject.Entity.DtoS;
using BenMabelProject.Entity.Entities;

namespace BenMabelProject.Services.AutoMapper.Articles
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<Article,ArticleDto>().ReverseMap();
            CreateMap<Article,ArticleUpdateDto>().ReverseMap();
        }
    }
}
