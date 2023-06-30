using AutoMapper;
using MediatR;
using STgenetics.Farm.Application.Dtos.Animal.Response;
using STgenetics.Farm.Application.Dtos.Common.Paginated;
using STgenetics.Farm.Application.Exceptions;
using STgenetics.Farm.Application.Interfaces.Repositories;
using STgenetics.Farm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STgenetics.Farm.Application.Features.Animals.Queries.GetAnimals
{
    internal class GetAnimalsHandler : IRequestHandler<GetAnimalsQuery, PagedList<AnimalResponse>>
    {
        private readonly IAnimalsRepositoryAsync _animalsRepositoryAsync;
        private readonly IMapper _mapper;

        public GetAnimalsHandler(IAnimalsRepositoryAsync animalsRepositoryAsync, IMapper mapper)
        {
            _animalsRepositoryAsync = animalsRepositoryAsync;
            _mapper = mapper;
        }
        public async Task<PagedList<AnimalResponse>> Handle(GetAnimalsQuery request, CancellationToken cancellationToken)
        {
            var animals = await _animalsRepositoryAsync.GetPagedReponseAsync(request.PageNumber, request.PageSize);

            if (animals.Count == 0)
                throw new NotFoundException("Not found animals");

            var totalAnimals = await _animalsRepositoryAsync.CountAsync();

            var animalsResponse = _mapper.Map<List<AnimalResponse>>(animals);
           
            return new PagedList<AnimalResponse>(animalsResponse, totalAnimals, request.PageNumber, request.PageSize);
        }
    }

}

