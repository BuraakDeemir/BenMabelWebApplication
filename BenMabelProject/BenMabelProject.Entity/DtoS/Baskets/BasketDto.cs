using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenMabelProject.Entity.DtoS.Basket
{
    public class BasketDto
    {
        public int Id { get; set; }
        public int BasketId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Piece { get; set; }
        public double KDV { get; set; }
        public double ProductPrice { get; set; }
        public double TotalPrice { get; set; }
    }
}
