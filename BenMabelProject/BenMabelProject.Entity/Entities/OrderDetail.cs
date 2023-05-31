namespace BenMabelProject.Entity.Entities
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public double Piece { get; set; }
        public decimal Price { get; set; }
        public double KDV { get; set; }
        public decimal TotalPrice { get; set; }
        public Order? Order { get; set; }
        public Product? Product { get; set; }
    }
}
