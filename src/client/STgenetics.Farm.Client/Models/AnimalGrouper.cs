using STgenetics.Farm.Client.Models.Response;

namespace STgenetics.Farm.Client.Models
{
    public class AnimalGrouper
    {
        public string? Breed { get; set; }
        
        public List<AnimalResponse> animals { get; set; } = new List<AnimalResponse>();

        public decimal TotalAmount { get; set; }
        
        public decimal TotalAmountWithDiscount { get; set;}
    }
}
