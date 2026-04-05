using WebApplication4.Models;
using Films.Application.Interfaces;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Films.Application.Logic.Groups.Create;

public class CreateFilmCommandHandler(
    IApplicationDbContext dbContext)
    : IRequestHandler<CreateFilmCommand, Guid>
{
    public async Task<Guid> Handle(CreateFilmCommand request, CancellationToken cancellationToken)
    { 
        //var film = new Film(request.FilmName, request.director, request.style, request.description);
        //dbContext.Films.Add(film);
        //await dbContext.SaveChangesAsync(cancellationToken);
        throw new Exception();
    }
}