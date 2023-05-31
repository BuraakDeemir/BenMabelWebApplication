using BenMabelProject.Core.Entities;
using Microsoft.AspNetCore.Identity;

namespace BenMabelProject.Entity.Entities
{
    public class AppUser : IdentityUser<Guid>, IEntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
