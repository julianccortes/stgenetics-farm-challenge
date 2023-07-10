namespace STgenetics.Farm.Application.Features.Animals.Commands.CreateAnimal
{
    using AutoMapper;
    using MediatR;
    using STgenetics.Farm.Application.Dtos.Animal.Response;
    using STgenetics.Farm.Application.Interfaces.Repositories;
    using STgenetics.Farm.Domain.Entities;
    public class UpdateAnimalHandler : IRequestHandler<CreateAnimalCommand, AnimalResponse>
    {
        private readonly IAnimalsRepositoryAsync _animalsRepositoryAsync;
        private readonly IMapper _mapper;

        public UpdateAnimalHandler(IAnimalsRepositoryAsync animalsRepositoryAsync, IMapper mapper)
        {
            _animalsRepositoryAsync = animalsRepositoryAsync;
            _mapper = mapper;
        }

        public async Task<AnimalResponse> Handle(CreateAnimalCommand request, CancellationToken cancellationToken)
        {
            var animal = _mapper.Map<Animal>(request);
            await _animalsRepositoryAsync.AddAsync(animal);

            var animalResponse = _mapper.Map<AnimalResponse>(animal);

            return await Task.FromResult(animalResponse);
            
        }
    }
}
