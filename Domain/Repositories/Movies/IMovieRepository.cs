using Domain.Movies;
using Domain.Repositories.Base;

namespace Domain.Repositories.Movies;

public interface IMovieRepository : IRepository<Movie>
{
    Task<IEnumerable<Movie>> GetMoviesByDirectorNameAsync(string directorName);
    Task<IEnumerable<Movie>> GetMoviesByReleaseYearAsync(string releaseYear);
}