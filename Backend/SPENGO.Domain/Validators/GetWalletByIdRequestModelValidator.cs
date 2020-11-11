using FluentValidation;
using SPENGO.Domain.Models.RequestModels.QueryRequestModels;

namespace SPENGO.Domain.Validators
{
    public class GetWalletByIdRequestModelValidator : AbstractValidator<GetWalletByIdRequestModel>
    {
        public GetWalletByIdRequestModelValidator()
        {
            RuleFor(x => x.Id)
                .Length(10).WithMessage("The length of Id is 10 caracters.");
        }
    }
}
