namespace STgenetics.Farm.Application.Features.Animals.Commands.UpdateAnimal
{
    using AutoMapper;
    using MediatR;
    using STgenetics.Farm.Application.Dtos.Animal.Response;
    using STgenetics.Farm.Application.Dtos.Common.Created;
    using STgenetics.Farm.Application.Exceptions;
    using STgenetics.Farm.Application.Interfaces.Repositories;
    using STgenetics.Farm.Domain.Entities;
    public class UpdateAnimalHandler : IRequestHandler<UpdateAnimalCommand, AnimalResponse>
    {
        private readonly IAnimalsRepositoryAsync _animalsRepositoryAsync;
        private readonly IMapper _mapper;

        public UpdateAnimalHandler(IAnimalsRepositoryAsync animalsRepositoryAsync, IMapper mapper)
        {
            _animalsRepositoryAsync = animalsRepositoryAsync;
            _mapper = mapper;
        }

        public async Task<AnimalResponse> Handle(UpdateAnimalCommand request, CancellationToken cancellationToken)
        {
            var animal = await _animalsRepositoryAsync.GetByIdAsync(request.Id) ?? throw new NotFoundException(nameof(Animal), request.Id);

            var animalRequest = _mapper.Map<Animal>(request);

            await _animalsRepositoryAsync.UpdateAsync(animalRequest);

            var animalResponse = _mapper.Map<AnimalResponse>(animalRequest);

            return await Task.FromResult(animalResponse);
            
        }
    }
}
