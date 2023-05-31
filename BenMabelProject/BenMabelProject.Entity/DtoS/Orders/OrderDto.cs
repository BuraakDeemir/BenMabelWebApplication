
using BenMabelProject.Entity.Entities;

namespace BenMabelProject.Entity.DtoS.Order
{
    public class OrderDto
    {
        public Person person { get; set; }
        public PersonAdress adress { get; set; }
        public PersonEmail email { get; set; }
        public PersonIphone phone { get; set; }
        public BenMabelProject.Entity.Entities.Basket basket { get; set; }
        public List<BasketDetail> basketDetails { get; set; }
    }
}
