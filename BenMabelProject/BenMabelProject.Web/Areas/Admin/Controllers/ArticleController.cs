using BenMabelProject.Entity.DtoS;
using BenMabelProject.Services.Services.Abstractions;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace BenMabelProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ArticleController : Controller
    {
        private readonly IArticleService articleService;
        private readonly IToastNotification toast;
        private readonly IValidator<ArticleDto> validator;
        private readonly IValidator<ArticleUpdateDto> validatorUpt;

        public ArticleController(IArticleService articleService,IToastNotification toast,IValidator<ArticleDto> validator,IValidator<ArticleUpdateDto> validatorUpt)
        {
            this.articleService = articleService;
            this.toast = toast;
            this.validator = validator;
            this.validatorUpt = validatorUpt;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> AddArticle()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddArticle(ArticleDto articleDto)
        {
            var result = await validator.ValidateAsync(articleDto);
            if (result.IsValid)
            {
                await articleService.AddArticle(articleDto);
                toast.AddSuccessToastMessage("Yazı Eklendi!", new ToastrOptions { Title = "Bravo!!", });
                return RedirectToAction("ShowAllArticle", "Article", new { Area = "Admin" });
            }
            else 
            {
                toast.AddErrorToastMessage("Hata");
                return View();
            }

        }
        [HttpGet]
        public async Task<IActionResult> ShowAllArticle()
        {
            var Articles = await articleService.GetAllArticle();
            return View(Articles);
        }
        [HttpGet]
        public async Task<IActionResult> ShowInActiveArticle()
        {
            var Articles = await articleService.GetInActiveArticle();
            return View(Articles);
        }
        [HttpGet]
        public async Task<IActionResult> ShowActiveArticle()
        {
            var Articles = await articleService.GetActiveArticle();
            return View(Articles);
        }
        public async Task <IActionResult> ActiveArticle(int Id)
        {
            await articleService.InActiveArticle(Id);
            toast.AddSuccessToastMessage("Yazı Yayından Kaldırıldı!",new ToastrOptions {Title="Bravo!!",});
            return RedirectToAction("ShowActiveArticle", "Article", new { Area = "Admin" });
        }
        public async Task<IActionResult> InActiveArticle(int Id)
        {
            await articleService.ActiveArticle(Id);
            toast.AddSuccessToastMessage("Yazı Tekrar Yayınlandı!", new ToastrOptions { Title = "Bravo!!", });
            return RedirectToAction("ShowInActiveArticle", "Article", new { Area = "Admin" });
        }
        public async Task<IActionResult> GetUpdateArticle(int Id)
        {
            var article = await articleService.GetUpdateArticle(Id);
            return View(article);
        }
        [HttpPost]
        public async Task<IActionResult> GetUpdateArticle(ArticleUpdateDto UpdateDto)
        {
            var result = await validatorUpt.ValidateAsync(UpdateDto);
            if (result.IsValid)
            {
                await articleService.UpdateArticle(UpdateDto);
                toast.AddSuccessToastMessage("Yazı Başarılı Bir Şekilde Güncellendi!", new ToastrOptions { Title = "Bravo!!", });
                return RedirectToAction("ShowAllArticle", "Article", new { Area = "Admin" });
            }
            else
            {
                var article = await articleService.GetUpdateArticle(UpdateDto.Id);
                toast.AddErrorToastMessage("Hata");
                return View(article);
            }
        }
    }
}
