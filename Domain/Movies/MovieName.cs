namespace Domain.Movies;

public sealed record MovieName
{
    public MovieName(string? value)
    {
        if(string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException(nameof(value));
        Value = value;
    }

    public string Value { get; }
}
