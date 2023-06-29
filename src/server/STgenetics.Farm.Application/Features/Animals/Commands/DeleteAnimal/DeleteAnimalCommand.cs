using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STgenetics.Farm.Application.Features.Animals.Commands.DeleteAnimal
{
    public class DeleteAnimalCommand: IRequest
    {
        public int Id { get; set; }
    }
}
