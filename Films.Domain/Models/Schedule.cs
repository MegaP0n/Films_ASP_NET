namespace WebApplication4.Models
{
    public class Schedule : ModelBase<Guid>
    {
        public Guid FilmId { get; set; }
        public Film Film { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public Schedule()
        {
            Id = Guid.NewGuid();
        }

        public Schedule(Guid filmId, DateTime startTime, DateTime endTime)
        {
            Id = Guid.NewGuid();
            FilmId = filmId;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
