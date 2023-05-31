using AutoMapper;
using BenMabelProject.Data.UnitOfWorks;
using BenMabelProject.Entity.DtoS.User;
using BenMabelProject.Entity.Entities;
using BenMabelProject.Services.Services.Abstractions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BenMabelProject.Services.Services.Concrete
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> userManager;
        private readonly IMapper mapper;
        private readonly RoleManager<AppRole> roleManager;
        private readonly IUnitOfWork unitOfWork;
        public UserService(UserManager<AppUser> userManager, IMapper mapper, RoleManager<AppRole> roleManager,IUnitOfWork unitOfWork)
        {
            this.userManager = userManager;
            this.mapper = mapper;
            this.roleManager = roleManager;
            this.unitOfWork = unitOfWork;
        }
        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Admin Arayüzünde Kullanıcıları Listeleme işlemini gerçekleştirir.
        /// </summary>
        public async Task<List<UserDto>> GetAllUserWithRoleAsync()
        {
            var users = await userManager.Users.ToListAsync();
            var map = mapper.Map<List<UserDto>>(users);
            foreach (var user in map)
            {
                var findUser = await userManager.FindByIdAsync(user.Id.ToString());
                var role = string.Join("", await userManager.GetRolesAsync(findUser));
                user.Role = role;
            }
            return map;
        } // Admin İçin

        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Admin Arayüzünde Kullanıcı Ekleme Aşamasında Rolleri Listeleme işlemini gerçekleştirir.
        /// </summary>
        public async Task<List<AppRole>> GetAllrolesAsync()
        {
            return await roleManager.Roles.ToListAsync();
        } // Admin İçin
        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Admin Arayüzünde Yeni Kullanıcı Ekleme işlemini gerçekleştirir.
        /// </summary>
        public async Task<IdentityResult> CreateUserAsync(UserAddDto userAddDto)
        {
            Person person = new Person();
            person.Name = userAddDto.FirstName;
            person.Surname = userAddDto.LastName;
            person.Situation = 0;
            await unitOfWork.GetRepository<Person>().AddAsync(person);
            await unitOfWork.SaveAsync();
            PersonUser personUser = new PersonUser();
            personUser.PersonId = person.Id;
            personUser.Username = userAddDto.Email;
            personUser.Password = userAddDto.Password;
            PersonIphone phone = new PersonIphone();
            phone.PersonId = person.Id;
            phone.Iphone = userAddDto.PhoneNumber;
            PersonEmail email = new PersonEmail();
            email.PersonId = person.Id;
            email.Email = userAddDto.Email;
            PersonAdress adress = new PersonAdress();
            adress.PersonId = person.Id;
            adress.Ctiy = userAddDto.Ctiy;
            adress.District = userAddDto.District;
            adress.Neighbourhood = userAddDto.Neighbourhood;
            adress.Street = userAddDto.Street;
            adress.Detail = userAddDto.Detail;
            await unitOfWork.GetRepository<PersonUser>().AddAsync(personUser);
            await unitOfWork.GetRepository<PersonIphone>().AddAsync(phone);
            await unitOfWork.GetRepository<PersonEmail>().AddAsync(email);
            await unitOfWork.GetRepository<PersonAdress>().AddAsync(adress);
            await unitOfWork.SaveAsync();
            var map = mapper.Map<AppUser>(userAddDto);
            map.UserName = userAddDto.Email;
            var result = await userManager
                .CreateAsync(map, string.IsNullOrEmpty(userAddDto.Password) ? "" : userAddDto.Password);
            if (result.Succeeded)
            {
                var findRole = await roleManager.FindByIdAsync(userAddDto.RoleId.ToString());
                await userManager.AddToRoleAsync(map, findRole.ToString());
                var personUpdate = await unitOfWork.GetRepository<Person>().GetAsync(b=>b.Id == person.Id);
                personUpdate.IdentityId = map.Id;
                await unitOfWork.GetRepository<Person>().UpdateAsync(personUpdate);
                Basket Xbasket = new Basket();
                Xbasket.PersonId = personUpdate.Id;
                await unitOfWork.GetRepository<Basket>().AddAsync(Xbasket);
                await unitOfWork.SaveAsync();
                return result;
            }
            else
            {
                return result;
            }
        } // Admin İçin
        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Admin Arayüzünde Kullanıcı Silme işlemini gerçekleştirir.
        /// </summary>
        public async Task<(IdentityResult ıdentityResult, string? FirstName)> DeleteUserAsync(Guid userId)
        {
            var user = await GetAppUserByIdAsync(userId);
            var result = await userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                return (result, user.FirstName);
            }
            else
            {
                return (result, null);
            }
        } // Admin İçin
        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Admin Arayüzünde Seçili Kullanıcının Bilgilerini Getirme işlemini gerçekleştirir.
        /// </summary>
        public async Task<AppUser> GetAppUserByIdAsync(Guid Userid)
        {
            return await userManager.FindByIdAsync(Userid.ToString());
        } // Admin İçin
        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Kullanıcı Arayüzünde Yeni Üye Ekleme işlemini gerçekleştirir.
        /// </summary>
        public async Task<IdentityResult> SignInCustomer(CustomerAddDto customerAddDto)
        {
            Person person = new Person();
            person.Name = customerAddDto.FirstName;
            person.Surname = customerAddDto.LastName;
            person.Situation = 0;
            await unitOfWork.GetRepository<Person>().AddAsync(person);
            await unitOfWork.SaveAsync();
            PersonUser personUser = new PersonUser();
            personUser.PersonId = person.Id;
            personUser.Username = customerAddDto.Email;
            personUser.Password = customerAddDto.Password;
            PersonIphone phone = new PersonIphone();
            phone.PersonId = person.Id;
            phone.Iphone = customerAddDto.PhoneNumber;
            PersonEmail email = new PersonEmail();
            email.PersonId = person.Id;
            email.Email = customerAddDto.Email;
            PersonAdress adress = new PersonAdress();
            adress.PersonId = person.Id;
            adress.Ctiy = customerAddDto.Ctiy;
            adress.District = customerAddDto.District;
            adress.Neighbourhood = customerAddDto.Neighbourhood;
            adress.Street = customerAddDto.Street;
            adress.Detail = customerAddDto.Detail;
            await unitOfWork.GetRepository<PersonUser>().AddAsync(personUser);
            await unitOfWork.GetRepository<PersonIphone>().AddAsync(phone);
            await unitOfWork.GetRepository<PersonEmail>().AddAsync(email);
            await unitOfWork.GetRepository<PersonAdress>().AddAsync(adress);
            await unitOfWork.SaveAsync();
            var Customer = new AppUser();
            Customer.FirstName = customerAddDto.FirstName;
            Customer.LastName = customerAddDto.LastName;
            Customer.Email = customerAddDto.Email;
            Customer.PhoneNumber = customerAddDto.PhoneNumber;
            Customer.UserName = customerAddDto.Email;
            var result = await userManager.CreateAsync(Customer, string.IsNullOrEmpty(customerAddDto.Password) ? "" : customerAddDto.Password);
            if (result.Succeeded)
            {
                var role = await roleManager.FindByIdAsync("00b258bc-7991-4ff1-a277-2b56e27e8a97");
                await userManager.AddToRoleAsync(Customer, role.ToString());
                var personUpdate = await unitOfWork.GetRepository<Person>().GetAsync(b => b.Id == person.Id);
                personUpdate.IdentityId = Customer.Id;
                await unitOfWork.GetRepository<Person>().UpdateAsync(personUpdate);
                Basket Xbasket = new Basket();
                Xbasket.PersonId = personUpdate.Id;
                await unitOfWork.GetRepository<Basket>().AddAsync(Xbasket);
                await unitOfWork.SaveAsync();
                return result;
            }
            else
            {
                return result;
            }
        } // Kullanıcı İçin
    }
}
