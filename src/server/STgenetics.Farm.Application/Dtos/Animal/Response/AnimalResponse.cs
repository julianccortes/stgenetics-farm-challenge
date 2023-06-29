namespace STgenetics.Farm.Application.Dtos.Animal.Response
{
    public class AnimalResponse
    {
        public int Id { get; set; }

        public string? Name { get; set; }


        public string? Breed { get; set; }

        public DateOnly Birthday { get; set; }

        public string? Gender { get; set; }

        public decimal Price { get; set; }

        public bool IsActive { get; set; }
    }
}
