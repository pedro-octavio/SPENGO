using FluentValidation;
using SPENGO.Domain.Handlers.CommandHandlers;

namespace SPENGO.Domain.Validators
{
    public class AddWalletGroupItemRequestModelValidator : AbstractValidator<AddWalletGroupItemRequestModel>
    {
        public AddWalletGroupItemRequestModelValidator()
        {
            RuleFor(x => x.WalletGroupId)
                .Length(10).WithMessage("The length of WalletId is 10 characters.");

            RuleFor(x => x.Name)
                .NotNull().WithMessage("Name cannot be null.")
                .NotEmpty().WithMessage("Name cannot be empty.")
                .MaximumLength(40).WithMessage("The maximum length of name is 40 caracters.");

            RuleFor(x => x.Type)
                .Must(VerifyTypeValues).WithMessage("Invalid Type value.");
        }

        private bool VerifyTypeValues(int type)
        {
            if (type == 0 || type == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
