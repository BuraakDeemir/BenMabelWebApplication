using BenMabelProject.Services.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace BenMabelProject.Web.Controllers
{
    public class BlogController : Controller
    {
        private readonly IArticleService service;

        public BlogController(IArticleService service)
        {
            this.service = service;
        }
        public async Task<IActionResult> Index()
        {
            var articles = await service.AllArticleWidtImage();
            return View(articles);
        }
        public async Task<IActionResult> Detail(int Id)
        {
            var article = await service.GetArticleDetail(Id);
            return View(article);
        }
    }
}
