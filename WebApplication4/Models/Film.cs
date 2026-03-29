namespace WebApplication4.Models
{
    public class Film : ModelBase<Guid>
    {
        public required string Name { get; set; }
        public Director? Director { get; set; }
        public Style? Style { get; set; }
        public string? Description { get; set; }
        // список сеансов...

        public Film()
        {
            Id = Guid.NewGuid();
        }

        public Film(string name, Director? director, Style? style, string? description)
        {
            Id = Guid.NewGuid();
            Name = name;
            Director = director;
            Style = style;
            Description = description;
            //список сеансов...
        }
    }
}
