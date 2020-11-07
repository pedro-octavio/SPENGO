using MediatR;
using SPENGO.Domain.Models.ResponseModel.CommandResponseModels;
using SPENGO.Domain.Models.ResponseModel.Shared;
using System;

namespace SPENGO.Domain.Models.RequestModels.CommandRequestModels
{
    public class UpdateWalletRequestModel : IRequest<ReponseModel<UpdateWalletResponseModel>>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
