using FluentValidation;

namespace SchoolManagementSystem.API.Dtos.Validations
{
    public class StudentsForReturnDtoValidator: AbstractValidator<StudentsForReturnDto>
    {
         public StudentsForReturnDtoValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Username cannot be empty");
            RuleFor(x => x.Gender).NotEmpty().WithMessage("Gender cannot be empty");
            RuleFor(x => x.Gender).Length(4,6).WithMessage("Gender must be between 4 and 6 characters");
        }
    }
}