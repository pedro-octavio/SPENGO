using MediatR;
using SPENGO.Domain.Models.ResponseModel.CommandResponseModels;
using SPENGO.Domain.Models.ResponseModel.Shared;

namespace SPENGO.Domain.Models.RequestModels.CommandRequestModels
{
    public class DeleteWalletGroupRequestModel : IRequest<ResponseModel<DeleteWalletGroupResponseModel>>
    {
        public string Id { get; set; }
    }
}
