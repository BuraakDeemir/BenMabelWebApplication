namespace BenMabelProject.Entity.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public Guid IdentityId { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int? Situation { get; set; }
        public ICollection<PersonAdress>? PersonAdress { get; set; }
        public ICollection<PersonEmail>? PersonEmail { get; set; }
        public ICollection<PersonIphone>? PersonIphone { get; set; }
        public PersonUser? PersonUser { get; set; }
        public Basket? Basket { get; set; }
        public ICollection<Order>? Order { get; set; }
    }
}
