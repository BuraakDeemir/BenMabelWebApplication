using BenMabelProject.Entity.DtoS.User;
using BenMabelProject.Services.Services.Abstractions;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace BenMabelProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class UserController : Controller
    {
        private readonly IUserService userService;
        private readonly IToastNotification toast;
        private readonly IValidator<UserAddDto> validator;

        public UserController(IUserService userService,IToastNotification toast,IValidator<UserAddDto> validator)
        {
            this.userService = userService;
            this.toast = toast;
            this.validator = validator;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AllUser()
        {
            var users = await userService.GetAllUserWithRoleAsync();
            return View(users);
        }

        [HttpGet]
        public async Task<IActionResult> AddUser()
        {
            var roles = await userService.GetAllrolesAsync();
            return View(new UserAddDto { Roles = roles });
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(UserAddDto userAddDto)
        {
            var result = await validator.ValidateAsync(userAddDto);
            if (result.IsValid)
            {
                await userService.CreateUserAsync(userAddDto);
                toast.AddSuccessToastMessage("Kullanıcı Başarılı Bir Şekilde Eklendi", new ToastrOptions { Title = "Bravo!!", });
                return RedirectToAction("AllUser", "User", new { Area = "Admin" });
            }
            else
            {
                var roles = await userService.GetAllrolesAsync();
                return View(new UserAddDto { Roles = roles });
            }

        }

        [HttpGet]
        public async Task<IActionResult> RemoveUser()
        {
            var users = await userService.GetAllUserWithRoleAsync();
            return View(users);
        }
        [HttpGet]
        public async Task<IActionResult> RemoveUserAction(Guid UserId)
        {
            var result = await userService.DeleteUserAsync(UserId);
            toast.AddSuccessToastMessage("Kullanıcı Başarılı Bir Şekilde Silindi", new ToastrOptions { Title = "Bravo!!", });
            return RedirectToAction("RemoveUser", "User", new { Area = "Admin" });
        }
        public IActionResult AuthorizationUser()
        {
            return View();
        }

    }
}
