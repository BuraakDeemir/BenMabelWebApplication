namespace BenMabelProject.Entity.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public bool IsDeleted { get; set; }
        public int Adet { get; set; }
        public Category? Category { get; set; }
        public ProductPrice? ProductPrice { get; set; }
        public ProductImg? ProductImg { get; set; }
        public ProductDetail? ProductDetail { get; set; }
        public ICollection<BasketDetail>? BasketDetail { get; set; }
        public ICollection<OrderDetail>? OrderDetail { get; set; }
    }
}
