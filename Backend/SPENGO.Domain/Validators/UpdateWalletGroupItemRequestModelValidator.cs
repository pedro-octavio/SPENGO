using FluentValidation;
using SPENGO.Domain.Models.RequestModels.CommandRequestModels;

namespace SPENGO.Domain.Validators
{
    public class UpdateWalletGroupItemRequestModelValidator : AbstractValidator<UpdateWalletGroupItemRequestModel>
    {
        public UpdateWalletGroupItemRequestModelValidator()
        {
            RuleFor(x => x.Id)
                .Length(10).WithMessage("The length of Id is 10 caracters.");

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
