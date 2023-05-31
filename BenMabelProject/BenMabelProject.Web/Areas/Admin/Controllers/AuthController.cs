using BenMabelProject.Entity.DtoS.User;
using BenMabelProject.Entity.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace BenMabelProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly IToastNotification toast;

        public AuthController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,IToastNotification toast)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.toast = toast;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
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
                        return RedirectToAction("Index", "Home", new { Area = "Admin" });
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
            await signInManager.SignOutAsync();
            return RedirectToAction("Login", "Auth", new { Area = "Admin" });
        }
    }
}
