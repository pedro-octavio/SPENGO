using MediatR;
using SPENGO.Domain.Models.ResponseModel.CommandResponseModels;
using SPENGO.Domain.Models.ResponseModel.Shared;

namespace SPENGO.Domain.Models.RequestModels.CommandRequestModels
{
    public class UpdateWalletGroupItemRequestModel : IRequest<ResponseModel<UpdateWalletGroupItemResponseModel>>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public double Value { get; set; }
    }
}
