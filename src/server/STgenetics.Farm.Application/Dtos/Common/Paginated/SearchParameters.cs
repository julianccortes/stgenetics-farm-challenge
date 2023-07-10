namespace STgenetics.Farm.Application.Dtos.Common.Paginated
{
    public class SearchParameters
    {
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

        public string ShortOrder{ get; set; } = "asc";
    }
}
