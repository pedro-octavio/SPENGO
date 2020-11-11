using FluentValidation;
using SPENGO.Domain.Models.RequestModels.QueryRequestModels;

namespace SPENGO.Domain.Validators
{
    public class GetAllWalletRequestModelValidator : AbstractValidator<GetAllWalletRequestModel>
    {
        public GetAllWalletRequestModelValidator()
        {

        }
    }
}
