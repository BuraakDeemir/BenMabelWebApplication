using AutoMapper;
using BenMabelProject.Entity.DtoS.Products;
using BenMabelProject.Entity.Entities;
using BenMabelProject.Services.Extensions;
using BenMabelProject.Services.Services.Abstractions;
using BenMabelProject.Web.Messages;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace BenMabelProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;
        private readonly IMapper mapper;
        private readonly IValidator<Product> validator;
        private readonly IToastNotification toast;
        public ProductController(
            IProductService productService,
            ICategoryService categoryService,
            IMapper mapper,
            IValidator<Product> validator,
            IToastNotification toast)
        {
            this.productService = productService;
            this.categoryService = categoryService;
            this.mapper = mapper;
            this.validator = validator;
            this.toast = toast;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> AllProduct()
        {
            var products = await productService.GetAllProductForAdmin();
            return View(products);
        }
        [HttpGet]
        public async Task<IActionResult> AddProduct()
        {
            var categories = await categoryService.GetAllCategories();
            return View(new ProductAddDto { Categories = categories });
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductAddDto productAddDto)
        {
            var map = mapper.Map<Product>(productAddDto);
            var result = await validator.ValidateAsync(map);
            if (result.IsValid)
            {
                await productService.AddProductAsync(productAddDto);
                toast.AddSuccessToastMessage(ResultMessages.Product.Add(productAddDto.ProductName), new ToastrOptions { Title = "Bravo!!", });
                return RedirectToAction("AddProduct", "Product", new { Area = "Admin" });

            }
            else
            {
                result.AddToModelState(this.ModelState);
                toast.AddErrorToastMessage("İşlem Başarısız...", new ToastrOptions { Title = "Opps!!", });
                var categories = await categoryService.GetAllCategories();
                return View(new ProductAddDto { Categories = categories });
            }
        }
        [HttpGet]
        public async Task<IActionResult> UpdateProduct()
        {
            var produts = await productService.GetAllProductForAdmin();
            return View(produts);
        }
        [HttpGet]
        public async Task<IActionResult> RemoveProductFormSaleList()
        {
            var produts = await productService.GetAllProductForRemove();
            return View(produts);
        }
        public async Task<IActionResult> RemoveProductFormSale(int productId)
        {
            var productName = await productService.SafeDeleteProduct(productId);
            toast.AddSuccessToastMessage(ResultMessages.Product.Delete(productName), new ToastrOptions { Title = "Bravo!!", });
            return RedirectToAction("RemoveProductFormSaleList", "Product", new { Area = "Admin" });
        }
        [HttpGet]
        public async Task<IActionResult> ActiveProductFormSaleList()
        {
            var produts = await productService.GetAllProductForActive();
            return View(produts);
        }
        public async Task<IActionResult> ActiveProductFormSale(int productId)
        {
            var productName = await productService.AgainSaleProduct(productId);
            toast.AddSuccessToastMessage(ResultMessages.Product.UndoDelete(productName), new ToastrOptions { Title = "Bravo!!", });
            return RedirectToAction("ActiveProductFormSaleList", "Product", new { Area = "Admin" });
        }
        [HttpGet]
        public async Task<IActionResult> UpdateProductDetail(int productId)
        {
            var product = await productService.GetProduct(productId);
            var categories = await categoryService.GetAllCategories();
            product.Categories = categories;
            return View(product);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateProductDetail(ProductUpdateDto productUpdateDto)
        {
            var map = mapper.Map<Product>(productUpdateDto);
            var result = await validator.ValidateAsync(map);
            if (result.IsValid)
            {
                var Name = await productService.UpdateProduct(productUpdateDto);
                toast.AddSuccessToastMessage(ResultMessages.Product.Update(Name), new ToastrOptions { Title = "Bravo!!", });
                return RedirectToAction("UpdateProduct", "Product", new { Area = "Admin" });

            }
            else
            {
                result.AddToModelState(this.ModelState);
                toast.AddErrorToastMessage("İşlem Başarısız...", new ToastrOptions { Title = "Opps!!", });
                var categories = await categoryService.GetAllCategories();
                return View(new ProductUpdateDto { Categories = categories });
            }
        }
    }
}
