namespace STgenetics.Farm.Application.Interfaces.Repositories
{
    public interface IGenericRepositoryAsync<T, PrimaryKeyType>
        where T : class
        where PrimaryKeyType : struct
    {
        Task<T> GetByIdAsync(PrimaryKeyType id);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<IReadOnlyList<T>> GetPagedReponseAsync(int pageNumber, int pageSize);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);

        Task<int> CountAsync();
    }
}
