namespace STgenetics.Farm.Infrastructure.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using STgenetics.Farm.Application.Interfaces.Repositories;
    using STgenetics.Farm.Infrastructure.Context;
    public class GenericRepositoryAsync<T, PrimaryKeyType> : IGenericRepositoryAsync<T, PrimaryKeyType>
           where T : class
           where PrimaryKeyType : struct
    {
        private readonly ApplicationFarmContext _dbContext;

        public GenericRepositoryAsync(ApplicationFarmContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IReadOnlyList<T>> GetPagedReponseAsync(int pageNumber, int pageSize)
        {
            return await _dbContext
                .Set<T>()
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _dbContext
                 .Set<T>()
                 .ToListAsync();
        }

        public async Task<T> GetByIdAsync(PrimaryKeyType id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }
    }
}
