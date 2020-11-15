using FluentValidation;
using SPENGO.Domain.Models.RequestModels.CommandRequestModels;

namespace SPENGO.Domain.Validators
{
    public class AddWalletGroupRequestModelValidator : AbstractValidator<AddWalletGroupRequestModel>
    {
        public AddWalletGroupRequestModelValidator()
        {
            RuleFor(x => x.WalletId)
                .Length(10).WithMessage("The length of WalletId is 10 characters.");

            RuleFor(x => x.Name)
                .NotNull().WithMessage("Name cannot be null.")
                .NotEmpty().WithMessage("Name cannot be empty.")
                .MaximumLength(40).WithMessage("The maximum length of name is 40 caracters.");
        }
    }
}
