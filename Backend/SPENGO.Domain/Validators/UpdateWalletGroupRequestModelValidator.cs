using FluentValidation;
using SPENGO.Domain.Models.RequestModels.CommandRequestModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SPENGO.Domain.Validators
{
    public class UpdateWalletGroupRequestModelValidator : AbstractValidator<UpdateWalletGroupRequestModel>
    {
        public UpdateWalletGroupRequestModelValidator()
        {
            RuleFor(x => x.Id)
                .Length(10).WithMessage("The length of Id is 10 caracters.");

            RuleFor(x => x.Name)
                .NotNull().WithMessage("Name cannot be null.")
                .NotEmpty().WithMessage("Name cannot be empty.")
                .MaximumLength(40).WithMessage("The maximum length of name is 40 caracters.");
        }
    }
}
