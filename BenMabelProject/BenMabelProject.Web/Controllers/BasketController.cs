using BenMabelProject.Entity.DtoS.Products;
using BenMabelProject.Services.Extensions;
using BenMabelProject.Services.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System.Security.Claims;

namespace BenMabelProject.Web.Controllers
{
    public class BasketController : Controller
    {
        private readonly IBasketService service;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IToastNotification toast;
        private readonly ClaimsPrincipal _User;

        public BasketController(IBasketService service, IHttpContextAccessor httpContextAccessor,IToastNotification toast)
        {
            this.service = service;
            this.httpContextAccessor = httpContextAccessor;
            this.toast = toast;
            _User = httpContextAccessor.HttpContext.User;
        }
        public async Task<IActionResult> Index()
        {
            var Email = _User.GetLoggedInEmail();
            if (Email == null)
            {
                toast.AddErrorToastMessage("Lütfen Giriş Yapın", new ToastrOptions { Title="Hata!!"});
                return RedirectToAction("LoginPage", "User");
            }
            else
            {
                var AllBasket = await service.ShowBasket();
                return View(AllBasket);
            }
        }
        public async Task<IActionResult> DeleteProductFromBasket(int Id)
        {
            await service.DeleteProductFromBasket(Id);
            toast.AddSuccessToastMessage("Ürün Sepetten Çıkartıldı!");
            return RedirectToAction("Index", "Basket");
        }
    }
}
