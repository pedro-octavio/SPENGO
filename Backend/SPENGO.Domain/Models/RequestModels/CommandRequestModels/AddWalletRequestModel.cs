using MediatR;
using SPENGO.Domain.Models.ResponseModel.CommandResponseModels;
using SPENGO.Domain.Models.ResponseModel.Shared;
using System;

namespace SPENGO.Domain.Models.RequestModels.CommandRequestModels
{
    public class AddWalletRequestModel : IRequest<ResponseModel<AddWalletResponseModel>>
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
