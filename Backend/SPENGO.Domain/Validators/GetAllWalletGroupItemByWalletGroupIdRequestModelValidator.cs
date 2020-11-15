using FluentValidation;
using SPENGO.Domain.Models.RequestModels.QueryRequestModels;

namespace SPENGO.Domain.Validators
{
    public class GetAllWalletGroupItemByWalletGroupIdRequestModelValidator : AbstractValidator<GetAllWalletGroupItemByWalletGroupIdRequestModel>
    {
        public GetAllWalletGroupItemByWalletGroupIdRequestModelValidator()
        {
            RuleFor(x => x.WalletGroupId)
                .Length(10).WithMessage("The length of Id is 10 caracters.");
        }
    }
}
