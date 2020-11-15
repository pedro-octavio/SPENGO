using FluentValidation;
using SPENGO.Domain.Models.RequestModels.CommandRequestModels;

namespace SPENGO.Domain.Validators
{
    public class DeleteWalletGroupRequestModelValidator : AbstractValidator<DeleteWalletGroupRequestModel>
    {
        public DeleteWalletGroupRequestModelValidator()
        {
            RuleFor(x => x.Id)
                .Length(10).WithMessage("The length of Id is 10 caracters.");
        }
    }
}
