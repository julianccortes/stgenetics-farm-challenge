using STgenetics.Farm.Domain.Entities;
using STgenetics.Farm.Domain.Models;

namespace STgenetics.Farm.Application.Interfaces.Repositories
{
    public interface IAnimalsRepositoryAsync : IGenericRepositoryAsync<Animal, int>
    {

        Task<List<Animal>> GetAnimalsWithFiltersAsync(AnimalSearchCriteria criteria);

    }
}
