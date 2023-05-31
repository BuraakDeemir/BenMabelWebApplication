namespace BenMabelProject.Entity.Entities
{
    public class OrderSituation
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int Situation { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public DateTime? PreparationDate { get; set; }
        public DateTime? ShippingDate { get; set; }
        public DateTime? DeliveredDate { get; set; }
        public Order? Order { get; set; }

    }
}
