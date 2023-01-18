using CarRental.Core.DTOs;
using FluentValidation;

namespace CarRental.Service.Validations
{
    public class CarDtoValidator : AbstractValidator<CarDto>
    {
        public CarDtoValidator()
        {
            RuleFor(x => x.Brand).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{PropertyName} is required");

            RuleFor(x => x.Model).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{PropertyName} is required");

            RuleFor(x => x.RentalDuration).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be greater 0");
        }
    }
}
