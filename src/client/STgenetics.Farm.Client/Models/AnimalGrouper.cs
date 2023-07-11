using STgenetics.Farm.Client.Models.Response;

namespace STgenetics.Farm.Client.Models
{
    public class AnimalGrouper
    {
        public string? Breed { get; set; }
        
        public List<AnimalResponse> animals { get; set; } = new List<AnimalResponse>();

        public decimal TotalSumPrice
        {
            get
            {
                return animals.Sum(x => x.TotalPrice);
            }
            set { TotalSumPrice = value; }
        }


        public decimal TotalSumPriceWithDiscounts
        {
            get
            {
                return animals.Sum(x => x.FinalPrice);
            }
            set { TotalSumPriceWithDiscounts = value; }
        }

        public decimal TotalAnimalsQuantity
        {
            get
            {
                return animals.Sum(x => x.Quantity);
            }
            set { TotalAnimalsQuantity = value; }
        }


    }
}
