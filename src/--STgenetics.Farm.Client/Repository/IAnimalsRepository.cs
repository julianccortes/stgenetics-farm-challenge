using STgenetics.Farm.Client.Models.Request;
using STgenetics.Farm.Client.Models.Response;

namespace STgenetics.Farm.Client.Repository
{
    public interface IAnimalsRepository
    {
        Task<PagingResponse<AnimalResponse>> GetAnimalsByCriteria(AnimalSearchCriteria criteria);
    }


}
