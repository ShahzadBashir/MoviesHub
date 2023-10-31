using Domain.Abstractions;

namespace Domain.Movies;

public sealed class Movie : Entity
{
    private Movie(Guid id, MovieName movieName, DirectorName directorName, ReleaseYear releaseYear)
        : base(id)
    {
        MovieName = movieName;
        DirectorName = directorName;
        ReleaseYear = releaseYear;
    }
    public MovieName MovieName { get; private set; }
    public DirectorName DirectorName { get; private set; }
    public ReleaseYear ReleaseYear { get; private set; }

    public static Movie Create(MovieName movieName, DirectorName directorName, ReleaseYear releaseYear)
    {
        var movie = new Movie(Guid.NewGuid(), movieName,directorName,releaseYear);

        movie.Raise(new MovieCreatedDomainEvent(movie.Id));

        return movie;
    }
}