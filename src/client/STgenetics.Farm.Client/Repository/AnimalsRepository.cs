using Microsoft.AspNetCore.WebUtilities;
using STgenetics.Farm.Application.Dtos.Common.Paginated;
using STgenetics.Farm.Client.Models.Response;
using System.Text.Json;

namespace STgenetics.Farm.Client.Repository
{
    public class AnimalsRepository : IAnimalsRepository
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options;

        public AnimalsRepository(HttpClient client, JsonSerializerOptions options)
        {
            _client = client;
            _options = options;
        }
        public async Task<PagedResponse<AnimalResponse>> GetAnimals(SearchParameters searchParameter)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = searchParameter.PageNumber.ToString(),
                ["pageSize"] = searchParameter.PageSize.ToString()
            };
            
            using var response = await _client.GetAsync(QueryHelpers.AddQueryString("animals", queryStringParam));
            response.EnsureSuccessStatusCode();

            var stream = await response.Content.ReadAsStreamAsync();

            var pagingResponse = await JsonSerializer.DeserializeAsync<PagedResponse<AnimalResponse>>(stream, _options);

            return pagingResponse;
        }
    }
}
