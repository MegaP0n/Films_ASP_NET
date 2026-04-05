using MediatR;
using WebApplication4.Models;

namespace Films.Application.Logic.Groups.Create
{
        public sealed record CreateFilmCommand(string FilmName, Director? director, Style? style, string? description) : IRequest<Guid>;
}
