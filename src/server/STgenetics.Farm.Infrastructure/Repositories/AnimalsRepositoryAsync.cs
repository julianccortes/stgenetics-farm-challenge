namespace STgenetics.Farm.Infrastructure.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using STgenetics.Farm.Application.Interfaces.Repositories;
    using STgenetics.Farm.Domain.Entities;
    using STgenetics.Farm.Infrastructure.Context;

    public class AnimalsRepositoryAsync : GenericRepositoryAsync<Animal, int>, Application.Interfaces.Repositories.IAnimalsRepositoryAsync
    {

        private readonly DbSet<Animal> _animal;
        private readonly ApplicationFarmContext _dbContext;

        public AnimalsRepositoryAsync(ApplicationFarmContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
            _animal = dbContext.Set<Animal>();
        }
    }
}
