using MediatR;
using SPENGO.Domain.Models.ResponseModel.CommandResponseModels;
using SPENGO.Domain.Models.ResponseModel.Shared;

namespace SPENGO.Domain.Models.RequestModels.CommandRequestModels
{
    public class UpdateWalletGroupRequestModel : IRequest<ResponseModel<UpdateWalletGroupResponseModel>>
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
