using BenMabelProject.Entity.DtoS.User;
using BenMabelProject.Entity.Entities;
using Microsoft.AspNetCore.Identity;

namespace BenMabelProject.Services.Services.Abstractions
{
    public interface IUserService
    {
        Task<List<UserDto>> GetAllUserWithRoleAsync();
        Task<List<AppRole>> GetAllrolesAsync();
        Task<IdentityResult> CreateUserAsync(UserAddDto userAddDto);
        Task<(IdentityResult ıdentityResult, string? FirstName)> DeleteUserAsync(Guid userId);
        Task<IdentityResult> SignInCustomer(CustomerAddDto customerAddDto);
    }
}
