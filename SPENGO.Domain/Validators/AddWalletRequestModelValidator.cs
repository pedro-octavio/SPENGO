using FluentValidation;
using SPENGO.Domain.Models.RequestModels.CommandRequestModels;

namespace SPENGO.Domain.Validators
{
    public class AddWalletRequestModelValidator : AbstractValidator<AddWalletRequestModel>
    {
        public AddWalletRequestModelValidator()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("Name cannot be null.")
                .NotEmpty().WithMessage("Name cannot be empty.")
                .MaximumLength(40).WithMessage("The maximum length of name is 40 caracters.");

            RuleFor(x => x.StartDate)
                .NotNull().WithMessage("StartDate cannot be null.");

            RuleFor(x => x.EndDate)
                .NotNull().WithMessage("StartDate cannot be null.");
        }
    }
}
