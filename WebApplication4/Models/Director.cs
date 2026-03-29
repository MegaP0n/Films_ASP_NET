namespace WebApplication4.Models
{
    public class Director : ModelBase<Guid>
    {
        public required string Name { get; set; }
        public required string Surname { get; set; }

        public Director()
        {
            Id = Guid.NewGuid();
        }

        public Director(string name, string surname)
        {
            Id = Guid.NewGuid();
            Name = name;
            Surname = surname;
        }
    }
}
