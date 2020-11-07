using MediatR;
using SPENGO.Domain.Models.ResponseModel.CommandResponseModels;
using SPENGO.Domain.Models.ResponseModel.Shared;

namespace SPENGO.Domain.Models.RequestModels.CommandRequestModels
{
    public class DeleteWalletRequestModel : IRequest<ReponseModel<DeleteWalletResponseModel>>
    {
        public string Id { get; set; }
    }
}
