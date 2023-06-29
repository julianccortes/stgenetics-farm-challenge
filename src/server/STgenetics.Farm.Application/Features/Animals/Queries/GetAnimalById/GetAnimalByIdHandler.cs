using AutoMapper;
using MediatR;
using STgenetics.Farm.Application.Dtos.Animal.Response;
using STgenetics.Farm.Application.Exceptions;
using STgenetics.Farm.Application.Interfaces.Repositories;
using STgenetics.Farm.Domain.Entities;


namespace STgenetics.Farm.Application.Features.Animals.Queries.GetAnimalById
{
    public class GetAnimalByIdHandler : IRequestHandler<GetAnimalByIdQuery, AnimalResponse>
    {
        private readonly IAnimalsRepositoryAsync _animalsRepositoryAsync;
        private readonly IMapper _mapper;

        public GetAnimalByIdHandler(IAnimalsRepositoryAsync animalsRepositoryAsync, IMapper mapper)
        {
            _animalsRepositoryAsync = animalsRepositoryAsync;
            _mapper = mapper;
        }

        public async Task<AnimalResponse> Handle(GetAnimalByIdQuery request, CancellationToken cancellationToken)
        {
            var animal = await _animalsRepositoryAsync.GetByIdAsync(request.Id) ?? throw new NotFoundException(nameof(Animal), request.Id);

            var animalResponse = _mapper.Map<AnimalResponse>(animal);

            return await Task.FromResult(animalResponse);
        }
    }
}
