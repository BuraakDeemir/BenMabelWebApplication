using BenMabelProject.Entity.DtoS.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenMabelProject.Services.Services.Abstractions
{
    public interface IProfileService
    {
        Task<ProfileDto> ShowProfile();
    }
}
