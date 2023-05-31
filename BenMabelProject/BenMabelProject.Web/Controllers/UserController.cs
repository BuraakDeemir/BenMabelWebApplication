using BenMabelProject.Entity.DtoS.User;
using BenMabelProject.Entity.Entities;
using BenMabelProject.Services.Extensions;
using BenMabelProject.Services.Services.Abstractions;
using BenMabelProject.Services.Services.Concrete;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using NToastNotify;

namespace BenMabelProject.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IToastNotification toast;
        private readonly IValidator<CustomerAddDto> validator;

        public UserController(
            IUserService userService, 
            UserManager<AppUser> userManager, 
            SignInManager<AppUser> signInManager,
            IHttpContextAccessor httpContextAccessor,
            IToastNotification toast,
            IValidator<CustomerAddDto> validator)
        {
            this.userService = userService;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.httpContextAccessor = httpContextAccessor;
            this.toast = toast;
            this.validator = validator;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> SginIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SginIn(CustomerAddDto customerAddDto)
        {
            var result = await validator.ValidateAsync(customerAddDto);
            if (result.IsValid)
            {
                await userService.SignInCustomer(customerAddDto);
                toast.AddSuccessToastMessage("Üyelik İşleminiz Başarılı", new ToastrOptions { Title = "Tebrikler" });
                return RedirectToAction("LoginPage", "User");
            }
            else
            {
                result.AddToModelState(this.ModelState);
                toast.AddErrorToastMessage("Hata");
                return View();
            }

        }
        public async Task<IActionResult> LoginPage()
        {
            var UserId = httpContextAccessor.HttpContext.User.GetLoggedInEmail();
            if (UserId == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index","Profile");      
            }
            
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginDto userLoginDto)
        {
            if (ModelState.IsValid)
            {
                var User = await userManager.FindByEmailAsync(userLoginDto.Email);
                if (User != null)
                {
                    var result = await signInManager.PasswordSignInAsync(User, userLoginDto.Password, userLoginDto.RememberMe, false);
                    if (result.Succeeded)
                    {
                        toast.AddSuccessToastMessage("Giriş Başarılı!", new ToastrOptions { Title = "Bravo!!", });
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        toast.AddErrorToastMessage("E-Posta Adresiniz yada Şifreniz Hatalı!", new ToastrOptions { Title = "Hata!!", });
                        ModelState.AddModelError("", "E-Posta Adresiniz yada Şifreniz Hatalı.");
                        return View();
                    }
                }
                else
                {
                    toast.AddErrorToastMessage("E-Posta Adresiniz yada Şifreniz Hatalı!", new ToastrOptions { Title = "Hata!!", });
                    ModelState.AddModelError("", "E-Posta Adresiniz yada Şifreniz Hatalı.");
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            var email = httpContextAccessor.HttpContext.User.GetLoggedInEmail();
            if (email != null)
            {
                await signInManager.SignOutAsync();
                toast.AddSuccessToastMessage("Çıkış Yapıldı!", new ToastrOptions { Title = "Güle Güle!!", });
            }
            return RedirectToAction("LoginPage", "User");

        }
    }
}
