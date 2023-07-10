using STgenetics.Farm.Client.Models.Request;
using STgenetics.Farm.Client.Models.Response;

namespace STgenetics.Farm.Client.Repository
{
    public interface IAnimalsRepository
    {
        Task<Tuple<bool,PagingResponse<AnimalResponse>>> GetAnimalsByCriteria(AnimalSearchCriteria criteria);
    }


}
