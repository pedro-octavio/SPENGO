using FluentValidation;
using SPENGO.Domain.Models.RequestModels.QueryRequestModels;

namespace SPENGO.Domain.Validators
{
    public class GetAllWalletGroupByWalletIdRequestModelValidator : AbstractValidator<GetAllWalletGroupByWalletIdRequestModel>
    {
        public GetAllWalletGroupByWalletIdRequestModelValidator()
        {
            RuleFor(x => x.WalletId)
                .Length(10).WithMessage("The length of Id is 10 caracters.");
        }
    }
}
