namespace STgenetics.Farm.Application.Dtos.Common.Created
{
    public class CreatedResourceResponse<T>
    {
        public T? Id { get; set; }

        public string? UrlResource { get; set; }

        public CreatedResourceResponse(T id, string resource) {
            Id = id;
            UrlResource = resource;
        }

        public CreatedResourceResponse(T id)
        {
            Id = id;       
        }
    }
}
