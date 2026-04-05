namespace WebApplication4.Models
{
    public class Director : ModelBase<Guid>
    {
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public Guid FilmId { get; set; }
        public Film Film { get; set; }

        public Director()
        {
            Id = Guid.NewGuid();
        }

        public Director(string name, string surname, Guid filmId)
        {
            Id = Guid.NewGuid();
            Name = name;
            Surname = surname;
            FilmId = filmId;
        }
    }
}
