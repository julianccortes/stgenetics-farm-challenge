namespace STgenetics.Farm.Application.Features.Animals.Queries.GetAnimals
{
    using MediatR;
    using STgenetics.Farm.Application.Dtos.Animal.Response;
    using STgenetics.Farm.Application.Dtos.Common.Paginated;

    public class GetAnimalsQuery : SearchParameters, IRequest<PagedList<AnimalResponse>>
    {

    }
}
