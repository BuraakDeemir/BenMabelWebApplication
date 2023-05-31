using BenMabelProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenMabelProject.Entity.DtoS.Profiles
{
    public class ProfileDto
    {
        public Person person { get; set; }
        public List<PersonEmail> email { get; set; }
        public List<PersonIphone> phone { get; set; }
        public List<PersonAdress> adress { get; set; }
        public PersonUser user { get; set; }
        public List<BenMabelProject.Entity.Entities.Order>? order { get; set; }    
        public List<OrderPrice>? price { get; set; }
        public OrderSituation? orderSituation { get; set; }
    }
}
