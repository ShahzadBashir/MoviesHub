using Domain.Abstractions;

namespace Domain.Movies;

public sealed record MovieCreatedDomainEvent(Guid MovieId) : IDomainEvent;