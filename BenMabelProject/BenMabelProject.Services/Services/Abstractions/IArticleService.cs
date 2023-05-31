using BenMabelProject.Entity.DtoS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenMabelProject.Services.Services.Abstractions
{
    public interface IArticleService
    {
        Task<List<ArticleDto>> GetAllArticle();
        Task AddArticle(ArticleDto articleDto);
        Task UpdateArticle(ArticleUpdateDto articleDto);
        Task<List<ArticleDto>> GetInActiveArticle(); 
        Task InActiveArticle(int id);
        Task<List<ArticleDto>> GetActiveArticle();
        Task ActiveArticle(int id);
        Task<ArticleUpdateDto> GetUpdateArticle(int Id);
        Task<List<ArticleDto>> AllArticleWidtImage();
        Task<ArticleDto> GetArticleDetail(int Id);
    }
}
