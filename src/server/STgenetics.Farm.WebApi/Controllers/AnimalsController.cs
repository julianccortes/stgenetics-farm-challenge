using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using STgenetics.Farm.Application.Dtos.Animal.Response;
using STgenetics.Farm.Application.Dtos.Common.Created;
using STgenetics.Farm.Application.Dtos.Common.Errors;
using STgenetics.Farm.Application.Features.Animals.Commands.CreateAnimal;
using STgenetics.Farm.Application.Features.Animals.Commands.DeleteAnimal;
using STgenetics.Farm.Application.Features.Animals.Commands.UpdateAnimal;
using STgenetics.Farm.Application.Features.Animals.Queries.GetAnimalById;
using STgenetics.Farm.Application.Features.Animals.Queries.GetAnimals;
using System.Reflection.Metadata.Ecma335;

namespace STgenetics.Farm.WebApi.Controllers
{
    public class AnimalsController : BaseApiController
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<AnimalResponse>))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponse))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponse))]
        public async Task<IActionResult> GetAllAnimals([FromQuery] GetAnimalsQuery parameters) => Ok(await Mediator.Send(parameters));

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AnimalResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponse))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponse))]
        public async Task<IActionResult> CreateAnimal(CreateAnimalCommand command)
        {
            var animal = await Mediator.Send(command);
            return CreatedAtAction(nameof(GetAnimalById), new { animalId = animal.Id }, animal);
        }

        [HttpGet("{animalId}")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(AnimalResponse))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponse))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponse))]
        public async Task<IActionResult> GetAnimalById(int animalId) => Ok(await Mediator.Send(new GetAnimalByIdQuery { Id = animalId }));


        [HttpPut("{animalId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AnimalResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponse))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponse))]
        public async Task<IActionResult> UpdateAnimal(UpdateAnimalCommand command, int animalId)
        {
            if (command.Id != animalId)
                return BadRequest();

            command.Id = animalId;

            return Ok(await Mediator.Send(command));
        }

        [HttpDelete("{animalId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponse))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponse))]
        public async Task<IActionResult> DeleteAnimal( int animalId) => Ok(await Mediator.Send(new DeleteAnimalCommand() { Id = animalId }));    
    }
}
