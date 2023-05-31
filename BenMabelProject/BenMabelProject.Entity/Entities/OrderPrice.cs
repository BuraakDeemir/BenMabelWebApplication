namespace BenMabelProject.Entity.Entities
{
    public class OrderPrice
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public decimal TotalPrice { get; set; }
        public Order? Order { get; set; }
    }
}
