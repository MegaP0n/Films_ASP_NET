namespace WebApplication4.Models
{
    public class Style : ModelBase<Guid>
    {
        public required string Genre { get; set; }

        public Style()
        {
            Id = Guid.NewGuid();
        }

        public Style(string genre) 
        {
            Id = Guid.NewGuid();
            Genre = genre;
        }
    }
}
