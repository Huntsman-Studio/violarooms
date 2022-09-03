using Core.Models;

namespace Core.Interfaces;

public interface IGenericRepository<T> where T : Base
{
    Task<IReadOnlyList<T>> ListAllAsync();
    Task<T> GetByIdAsync(int id);
    Task<T> Add(T Base);
    Task<T> Update(T Base);
    Task<T> Delete(int id);
}
