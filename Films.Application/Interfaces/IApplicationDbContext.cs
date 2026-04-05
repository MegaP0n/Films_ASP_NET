using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;


namespace Films.Application.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Film> Films { get; set; }
    DbSet<Director> Directors { get; set; }
    DbSet<Schedule> Schedules { get; set; }
    DbSet<Style> Styles { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
