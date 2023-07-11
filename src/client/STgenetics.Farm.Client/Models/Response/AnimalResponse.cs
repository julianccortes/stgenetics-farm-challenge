namespace STgenetics.Farm.Client.Models.Response
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

        public int Quantity { get; set; } = 1;

        public decimal TotalPrice
        {
            get
            {
                return Price * Quantity;
            }
            set { TotalPrice = value; }
        }

        public decimal PercentajeDiscount
        {
            get
            {
                return Quantity > 5 ? 5 : 0;
            }
            set { PercentajeDiscount = value; }
        }

        public decimal FinalPrice
        {
            get
            {
                return UnitPriceDiscount * Quantity;
            }
            set { PercentajeDiscount = value; }
        }

        public decimal UnitPriceDiscount
        {
            get
            {
                return (Price - ((PercentajeDiscount * Price / 100)));
            }
            set { TotalPrice = value; }
        }
    }
}
