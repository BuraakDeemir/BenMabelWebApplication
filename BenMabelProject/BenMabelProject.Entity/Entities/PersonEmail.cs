namespace BenMabelProject.Entity.Entities
{
    public class PersonEmail
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string? Email { get; set; }
        public Person? Person { get; set; }
    }
}
