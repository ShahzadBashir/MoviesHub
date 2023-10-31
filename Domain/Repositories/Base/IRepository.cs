using Domain.Abstractions;

namespace Domain.Repositories.Base;

public interface IRepository<T> where T : Entity
{
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<T> GetByIdAsync(Guid id);
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}
