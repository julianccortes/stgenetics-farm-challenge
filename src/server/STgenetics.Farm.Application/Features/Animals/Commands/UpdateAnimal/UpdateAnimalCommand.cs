using MediatR;
using Newtonsoft.Json.Converters;
using STgenetics.Farm.Application.Dtos.Animal.Response;
using STgenetics.Farm.Application.Dtos.Common.Created;
using System.Text.Json.Serialization;

namespace STgenetics.Farm.Application.Features.Animals.Commands.UpdateAnimal
{
    public class UpdateAnimalCommand : IRequest<AnimalResponse>
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
