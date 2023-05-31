using BenMabelProject.Entity.DtoS.Products;
using BenMabelProject.Services.Services.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using NToastNotify;

namespace BenMabelProject.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly IBasketService basketService;
        private readonly IToastNotification toast;

        public ProductController(IProductService ProductService, IBasketService basketService, IToastNotification toast)
        {
            productService = ProductService;
            this.basketService = basketService;
            this.toast = toast;
        }
        public async Task<IActionResult> Index()
        {
            var products = await productService.GetAllProduct();
            return View(products);
        }
        public async Task<IActionResult> ProductsByCategory(int categoryId)
        {
            var products = await productService.GetCategoryProduct(categoryId);
            return View(products);
        }
        [HttpGet]
        public async Task<IActionResult> ProductDetail(int ProductId)
        {
            var product = await productService.GetProductById(ProductId);
            return View(product);
        }
        [HttpPost]
        public async Task<IActionResult> ProductDetail(ProductDto DetailDto)
        {
            var result = await basketService.AddBasket(DetailDto);
            if (result)
            {
                toast.AddSuccessToastMessage("Ürün Sepete Eklendi!", new ToastrOptions { Title = "Bravo!!" });
                return RedirectToAction("Index", "Basket");
            }
            else
            {
                toast.AddSuccessToastMessage("Sepet İşlemleri İçin Lütfen Giriş Yapın!", new ToastrOptions { Title = "Hata!!" });
                return RedirectToAction("LoginPage", "User");
            }

        }
    }
}
