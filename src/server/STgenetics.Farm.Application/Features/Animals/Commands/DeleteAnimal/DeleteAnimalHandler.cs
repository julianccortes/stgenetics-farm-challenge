using AutoMapper;
using MediatR;
using STgenetics.Farm.Application.Exceptions;
using STgenetics.Farm.Application.Interfaces.Repositories;
using STgenetics.Farm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STgenetics.Farm.Application.Features.Animals.Commands.DeleteAnimal
{
    public class DeleteAnimalHandler : IRequestHandler<DeleteAnimalCommand>
    {
        private readonly IAnimalsRepositoryAsync _animalsRepositoryAsync;
        private readonly IMapper _mapper;

        public DeleteAnimalHandler(IAnimalsRepositoryAsync animalsRepositoryAsync, IMapper mapper)
        {
            _animalsRepositoryAsync = animalsRepositoryAsync;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteAnimalCommand request, CancellationToken cancellationToken)
        {
            var animal = await _animalsRepositoryAsync.GetByIdAsync(request.Id) ?? throw new NotFoundException(nameof(Animal), request.Id);
            var animalToDelete = _mapper.Map<Animal>(animal);
                
            await _animalsRepositoryAsync.DeleteAsync(animalToDelete);

            return await Task.FromResult(Unit.Value);

        }
    }
}
