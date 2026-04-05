namespace WebApplication4.Models
{
    public class Film : ModelBase<Guid>
    {
        public string Name { get; set; }
        public Guid DirectorId { get; set; }
        public Director Director { get; set; }
        public Guid StyleId { get; set; }
        public Style Style { get; set; }
        public string? Description { get; set; }
        public Guid ScheduleId { get; set; }
        public Schedule Schedule { get; set; }


        public Film()
        {
            Id = Guid.NewGuid();
        }

        public Film(string name, Guid directorId, Guid styleId, string? description, Guid scheduleId)
        {
            Id = Guid.NewGuid();
            Name = name;
            DirectorId = directorId;
            StyleId = styleId;
            Description = description;
            ScheduleId = scheduleId;
        }
    }
}
