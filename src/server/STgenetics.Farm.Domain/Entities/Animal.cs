using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace STgenetics.Farm.Domain.Entities
{
    public class Animal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? Name { get; set; }


        public string? Breed { get; set; }

        public DateOnly Birthday { get; set; }

        public string? Gender { get; set; }

        public decimal Price { get; set; }

        public bool IsActive { get; set; }
    }
}
