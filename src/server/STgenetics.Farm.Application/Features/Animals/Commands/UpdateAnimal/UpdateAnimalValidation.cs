namespace STgenetics.Farm.Application.Features.Animals.Commands.UpdateAnimal
{
    using FluentValidation;
    using STgenetics.Farm.Application.Features.Animals.Common;
    using STgenetics.Farm.Domain.Constants;
    public class UpdateAnimalValidation : AbstractValidator<UpdateAnimalCommand>
    {
        public UpdateAnimalValidation()
        {
            RuleFor(v => v.Id).NotNull();
            RuleFor(v => v.Name).MaximumLength(64).NotEmpty();
            RuleFor(v => v.Breed).MaximumLength(64).NotEmpty();
            RuleFor(v => v.Birthday).NotEmpty();
            RuleFor(v => v.Gender).NotEmpty().Must(AnimalValidations.IsValidAnimalGender).WithMessage(CustomValidationMessages.INVALID_ANIMAL_GENDER); ;
            RuleFor(v => v.Price).GreaterThanOrEqualTo(0).WithMessage(CustomValidationMessages.INVALID_ANIMAL_PRICE);
            RuleFor(v => v.IsActive).NotNull();
        }

        private bool PriceValidation(decimal price) => (price >= 0);
    }
}
