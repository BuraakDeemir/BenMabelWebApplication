using BenMabelProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenMabelProject.Entity.DtoS.User
{
    public class CustomerAddDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string? Ctiy { get; set; }
        public string? District { get; set; }
        public string? Neighbourhood { get; set; }
        public string? Street { get; set; }
        public string? Detail { get; set; }
    }
}
