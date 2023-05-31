namespace BenMabelProject.Entity.Entities
{
    public class PersonUser
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public Person? Person { get; set; }
    }
}
