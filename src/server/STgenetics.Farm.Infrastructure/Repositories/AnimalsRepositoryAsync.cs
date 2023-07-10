namespace STgenetics.Farm.Infrastructure.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using STgenetics.Farm.Application.Interfaces.Repositories;
    using STgenetics.Farm.Domain.Entities;
    using STgenetics.Farm.Domain.Models;
    using STgenetics.Farm.Infrastructure.Common;
    using STgenetics.Farm.Infrastructure.Context;
    using System.Threading.Tasks;

    public class AnimalsRepositoryAsync : GenericRepositoryAsync<Animal, int>, IAnimalsRepositoryAsync
    {
        private readonly DbSet<Animal> _animal;

        public AnimalsRepositoryAsync(ApplicationFarmContext dbContext) : base(dbContext)
        {
            _animal = dbContext.Set<Animal>();
        }

        public async Task<List<Animal>> GetAnimalsWithFiltersAsync(AnimalSearchCriteria criteria)
        {
            return await _animal.Where(x =>
            (!criteria.Id.HasValue || x.Id == criteria.Id) &&
            (string.IsNullOrEmpty(criteria.Name) || x.Name.Equals(criteria.Name)) &&
            (string.IsNullOrEmpty(criteria.Breed) || x.Breed.Equals(criteria.Breed)) &&
            (!criteria.Birthday.HasValue || x.Birthday == criteria.Birthday) &&
            (!criteria.Price.HasValue || x.Price == criteria.Price) &&
            (!criteria.IsActive.HasValue || x.IsActive == criteria.IsActive)
            ).OrderByDynamic(criteria.ShortField, criteria.ShortOrder.ToUpper())
            .Skip((criteria.PageNumber - 1) * criteria.PageSize)
                .Take(criteria.PageSize)
                .AsNoTracking()
            .ToListAsync();
        }
    }
}
