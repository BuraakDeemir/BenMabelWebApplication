using AutoMapper;
using BenMabelProject.Entity.DtoS.User;
using BenMabelProject.Entity.Entities;

namespace BenMabelProject.Services.AutoMapper.User
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<AppUser, UserDto>().ReverseMap();
            CreateMap<AppUser, UserAddDto>().ReverseMap();

        }
    }
}
