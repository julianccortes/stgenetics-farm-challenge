namespace STgenetics.Farm.Domain.Models
{
    public class AnimalSearchCriteria
    {
        public int? Id { get; set; }

        public string? Name { get; set; }

        public string? Breed { get; set; }

        public DateOnly? Birthday { get; set; }

        public string? Gender { get; set; }

        public decimal? Price { get; set; }

        public bool? IsActive { get; set; }

        const int maxPageSize = 50;
        public int PageNumber { get; set; } = 1;

        private int _pageSize = 10;
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value > maxPageSize) ? maxPageSize : value;
            }
        }

        public string ShortField { get; set; } = "id";

        public string ShortOrder { get; set; } = "asc";
    }
}
