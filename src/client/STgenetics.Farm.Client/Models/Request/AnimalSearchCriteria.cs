namespace STgenetics.Farm.Client.Models.Request
{
    public class AnimalSearchCriteria : SearchParameters
    {
        public int? Id { get; set; }

        public string? Name { get; set; }

        public string? Breed { get; set; }

        public string? Gender { get; set; }

        public DateOnly? Birthday { get; set; }

        public decimal? Price { get; set; }

        public bool? IsActive { get; set; }
    }
}
