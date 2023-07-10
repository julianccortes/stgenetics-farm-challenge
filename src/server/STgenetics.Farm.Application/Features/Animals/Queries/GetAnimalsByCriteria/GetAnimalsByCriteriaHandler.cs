using AutoMapper;
using MediatR;
using STgenetics.Farm.Application.Dtos.Animal.Response;
using STgenetics.Farm.Application.Dtos.Common.Paginated;
using STgenetics.Farm.Application.Exceptions;
using STgenetics.Farm.Application.Interfaces.Repositories;
using STgenetics.Farm.Domain.Models;

namespace STgenetics.Farm.Application.Features.Animals.Queries.GetAnimalsByCriteria
{
    public class GetAnimalsByCriteriaHandler : IRequestHandler<GetAnimalsByCriteriaQuery, PagedList<AnimalResponse>>
    {
        private readonly IAnimalsRepositoryAsync _animalsRepositoryAsync;
        private readonly IMapper _mapper;

        public GetAnimalsByCriteriaHandler(IAnimalsRepositoryAsync animalsRepositoryAsync, IMapper mapper)
        {
            _animalsRepositoryAsync = animalsRepositoryAsync;
            _mapper = mapper;
        }

        public async Task<PagedList<AnimalResponse>> Handle(GetAnimalsByCriteriaQuery request, CancellationToken cancellationToken)
        {
            var criteria = _mapper.Map<AnimalSearchCriteria>(request);
            var animals = await _animalsRepositoryAsync.GetAnimalsWithFiltersAsync(criteria);

            if (animals.Count == 0)
                throw new NotFoundException("Not found animals with this criteria");

            var animalsResponse = _mapper.Map<List<AnimalResponse>>(animals);
            var totalAnimals = await _animalsRepositoryAsync.CountAsync();

            return new PagedList<AnimalResponse>(animalsResponse, totalAnimals, request.PageNumber, request.PageSize);
        }
    }
}
