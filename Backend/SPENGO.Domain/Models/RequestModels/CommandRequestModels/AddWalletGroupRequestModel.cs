using MediatR;
using SPENGO.Domain.Models.ResponseModel.CommandResponseModels;
using SPENGO.Domain.Models.ResponseModel.Shared;

namespace SPENGO.Domain.Models.RequestModels.CommandRequestModels
{
    public class AddWalletGroupRequestModel : IRequest<ResponseModel<AddWalletGroupResponseModel>>
    {
        public string WalletId { get; set; }
        public string Name { get; set; }
    }
}
