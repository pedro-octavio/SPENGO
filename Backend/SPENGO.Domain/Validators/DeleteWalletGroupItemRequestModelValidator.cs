using FluentValidation;
using SPENGO.Domain.Models.RequestModels.CommandRequestModels;

namespace SPENGO.Domain.Validators
{
    public class DeleteWalletGroupItemRequestModelValidator : AbstractValidator<DeleteWalletGroupItemRequestModel>
    {
        public DeleteWalletGroupItemRequestModelValidator()
        {
            RuleFor(x => x.Id)
                .Length(10).WithMessage("The length of Id is 10 caracters.");
        }
    }
}
