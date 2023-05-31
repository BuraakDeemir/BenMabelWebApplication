using BenMabelProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenMabelProject.Entity.DtoS.Orders
{
    public class OrderDetailDto
    {
        public Person person { get; set; }
        public BenMabelProject.Entity.Entities.Order order { get; set; }
        public List<PersonAdress> adress { get; set; }
        public List<PersonEmail> email { get; set; }
        public List<PersonIphone> phone { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
    }
}
