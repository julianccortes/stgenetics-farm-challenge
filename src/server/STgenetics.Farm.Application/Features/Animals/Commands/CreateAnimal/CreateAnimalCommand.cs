using MediatR;
using Newtonsoft.Json.Converters;
using STgenetics.Farm.Application.Dtos.Animal.Response;
using System.Text.Json.Serialization;

namespace STgenetics.Farm.Application.Features.Animals.Commands.CreateAnimal
{
    public class CreateAnimalCommand : IRequest<AnimalResponse>
    {
        public string? Name { get; set; }

        public string? Breed { get; set; }

        public DateOnly Birthday { get; set; }

        public string? Gender { get; set; }

        public decimal Price { get; set; }

        public bool IsActive { get; set; }
    }
}
