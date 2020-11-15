using MediatR;
using SPENGO.Domain.Models.ResponseModel.CommandResponseModels;
using SPENGO.Domain.Models.ResponseModel.Shared;

namespace SPENGO.Domain.Handlers.CommandHandlers
{
    public class AddWalletGroupItemRequestModel : IRequest<ResponseModel<AddWalletGroupItemResponseModel>>
    {
        public string WalletGroupId { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public double Value { get; set; }
    }
}
