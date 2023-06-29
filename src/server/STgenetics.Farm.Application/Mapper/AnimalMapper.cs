

namespace STgenetics.Farm.Application.Mapper
{
    using AutoMapper;
    using STgenetics.Farm.Application.Dtos.Animal.Response;
    using STgenetics.Farm.Application.Features.Animals.Commands.CreateAnimal;
    using STgenetics.Farm.Application.Features.Animals.Commands.UpdateAnimal;
    using STgenetics.Farm.Domain.Entities;

    public class AnimalMapper : Profile
    {
        public AnimalMapper()
        {
            CreateMap<Animal, AnimalResponse>();
            CreateMap<CreateAnimalCommand, Animal>();
            CreateMap<UpdateAnimalCommand, Animal>();
        }

    }
}
