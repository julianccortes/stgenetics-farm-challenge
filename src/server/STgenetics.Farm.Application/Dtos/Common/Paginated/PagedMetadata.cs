using System.Text.Json.Serialization;

namespace STgenetics.Farm.Application.Dtos.Common.Paginated
{    
    public class PagedMetadata
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }

        public bool HasPrevious => CurrentPage > 1;
        public bool HasNext => CurrentPage < TotalPages;
    }
}
