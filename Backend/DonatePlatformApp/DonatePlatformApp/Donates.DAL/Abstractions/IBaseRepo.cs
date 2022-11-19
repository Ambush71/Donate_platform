namespace Donates.DAL.Abstractions;

public interface IBaseRepo<T> where T:class
{
    Task<T?> GetAsync(int id);
    Task<IEnumerable<T>> GetManyAsync();
    Task<T> InsertAsync(T entity);
    T Update(T entity);
    void Delete(T entity);
}