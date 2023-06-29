namespace STgenetics.Farm.Application.Features.Animals.Queries.GetAnimalById
{
    using MediatR;
    using STgenetics.Farm.Application.Dtos.Animal.Response;
    public class GetAnimalByIdQuery: IRequest<AnimalResponse>
    {
        public int Id { get; set; }

    }
}
