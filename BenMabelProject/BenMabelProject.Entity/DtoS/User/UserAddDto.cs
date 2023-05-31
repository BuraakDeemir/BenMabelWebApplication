using BenMabelProject.Entity.Entities;

namespace BenMabelProject.Entity.DtoS.User
{
    public class UserAddDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Guid RoleId { get; set; }
        public List<AppRole> Roles { get; set; }
        public string? Ctiy { get; set; } = "boş";
        public string? District { get; set; } = "boş";
        public string? Neighbourhood { get; set; } = "boş";
        public string? Street { get; set; } = "boş";
        public string? Detail { get; set; } = "boş";
    }
}
