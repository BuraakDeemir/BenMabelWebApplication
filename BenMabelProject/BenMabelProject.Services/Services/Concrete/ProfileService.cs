using BenMabelProject.Data.UnitOfWorks;
using BenMabelProject.Entity.DtoS.Profiles;
using BenMabelProject.Entity.Entities;
using BenMabelProject.Services.Extensions;
using BenMabelProject.Services.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace BenMabelProject.Services.Services.Concrete
{
    public class ProfileService : IProfileService
    { 
        private readonly IUnitOfWork unitOfWork;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly ClaimsPrincipal _User;
        public ProfileService(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
            this.unitOfWork = unitOfWork;
            this.httpContextAccessor = httpContextAccessor;
            _User = httpContextAccessor.HttpContext.User;
        }

        // ===================================================================================================//

        /// <summary>
        /// Bu Mehdod Kullanıcı Arayüzünde Kullanıcının Kişisel Bilgilerini Listeleme işlemini gerçekleştirir.
        /// </summary>
        public async Task<ProfileDto> ShowProfile()
        {
            var userId= _User.GetLoggedInUserId();
            var person = await unitOfWork.GetRepository<Person>().GetAsync(b => b.IdentityId == userId);
            var order = await unitOfWork.GetRepository<Order>().GetAllAsync(b => b.PersonId == person.Id,b=> b.OrderPrice,b=> b.OrderSituation);
            ProfileDto profileDto = new ProfileDto();
            profileDto.person = person;
            profileDto.email = await unitOfWork.GetRepository<PersonEmail>().GetAllAsync(b=> b.PersonId == person.Id);
            profileDto.phone = await unitOfWork.GetRepository<PersonIphone>().GetAllAsync(b => b.PersonId == person.Id);
            profileDto.adress = await unitOfWork.GetRepository<PersonAdress>().GetAllAsync(b => b.PersonId == person.Id);
            profileDto.user = await unitOfWork.GetRepository<PersonUser>().GetAsync(b => b.PersonId == person.Id);
            profileDto.order = order;
            return profileDto;
        } // Kullanıcı İçin
    }
}
