using BenMabelProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenMabelProject.Entity.DtoS.Products
{
    public class ProductDetailDto
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public int CategoryId { get; set; }
        public int Stok { get; set; }
        public BenMabelProject.Entity.Entities.Category Category { get; set; }
        public ProductPrice ProductPrice { get; set; }
        public ProductImg ProductImg { get; set; }
        public ProductDetail ProductDetail { get; set; }
    }
}
