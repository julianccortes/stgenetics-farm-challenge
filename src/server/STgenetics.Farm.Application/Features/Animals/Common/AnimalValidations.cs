using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STgenetics.Farm.Application.Features.Animals.Common
{
    public static class AnimalValidations
    {
        public static bool IsValidAnimalGender(string? gender) {   
            if (gender == null)
                return false;

            return gender.ToLower().Equals("female") || gender.ToLower().Equals("male");
        }
    }
}
