using MediatR;
using STgenetics.Farm.Application.Dtos.Animal.Response;
using STgenetics.Farm.Application.Dtos.Common.Paginated;

namespace STgenetics.Farm.Application.Features.Animals.Queries.GetAnimalsByCriteria
{
    public class GetAnimalsByCriteriaQuery : SearchParameters, IRequest<PagedList<AnimalResponse>>
    {
        public int? Id { get; set; }

        public string? Name { get; set; }


        public string? Breed { get; set; }

        public DateOnly? Birthday { get; set; }

        public string? Gender { get; set; }

        public decimal? Price { get; set; }

        public bool? IsActive { get; set; }

    }
}
