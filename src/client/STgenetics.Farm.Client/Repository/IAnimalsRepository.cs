using STgenetics.Farm.Application.Dtos.Common.Paginated;
using STgenetics.Farm.Client.Models.Response;

namespace STgenetics.Farm.Client.Repository
{
    public interface IAnimalsRepository
    {
        Task<PagingResponse<AnimalResponse>> GetAnimals(SearchParameters searchParameter);
    }
}
