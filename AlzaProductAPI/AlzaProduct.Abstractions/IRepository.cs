namespace AlzaProduct.Abstractions;

public interface IRepository<T> where T : Entity
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetByIdAsync(string id);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    Task SaveAsync();
}
