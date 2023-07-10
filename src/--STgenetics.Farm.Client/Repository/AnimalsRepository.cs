using Microsoft.AspNetCore.WebUtilities;
using STgenetics.Farm.Client.Models.Request;
using STgenetics.Farm.Client.Models.Response;
using System.Text.Json;

namespace STgenetics.Farm.Client.Repository
{
    public class AnimalsRepository : IAnimalsRepository
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options;

        public AnimalsRepository(HttpClient client)
        {
            _client = client;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public async Task<PagingResponse<AnimalResponse>> GetAnimalsByCriteria(AnimalSearchCriteria criteria)
        {
            throw new NotImplementedException();
        }

        private Dictionary<string, string> buildSearchParameters(AnimalSearchCriteria criteria)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = criteria.PageNumber.ToString(),
                ["pageSize"] = criteria.PageSize.ToString()
            };

            if (criteria.Id.HasValue)
                queryStringParam.Add("id", criteria.Id.Value.ToString());

            if (string.IsNullOrEmpty(criteria.Name))
                queryStringParam.Add("name", criteria.Name.ToString());

            if (string.IsNullOrEmpty(criteria.Breed))
                queryStringParam.Add("breed", criteria.Breed.ToString());

            if (criteria.Birthday != null)
                queryStringParam.Add("birthday", criteria.Birthday.Value.ToString());

            if (criteria.Price != null)
                queryStringParam.Add("price", criteria.Price.Value.ToString());


            if (criteria.IsActive.HasValue)
                queryStringParam.Add("isactive", criteria.IsActive.Value.ToString());

            if (string.IsNullOrEmpty(criteria.ShortOrder))
                queryStringParam.Add("shortorder", criteria.ShortOrder.ToString());

            if (string.IsNullOrEmpty(criteria.ShortField))
                queryStringParam.Add("shortfield", criteria.ShortField.ToString());

            return queryStringParam;
        }
    }
}
