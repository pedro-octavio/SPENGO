using MediatR;
using SPENGO.Domain.Models.ResponseModel.QueryResponseModels;
using SPENGO.Domain.Models.ResponseModel.Shared;
using System.Collections.Generic;

namespace SPENGO.Domain.Models.RequestModels.QueryRequestModels
{
    public class GetAllWalletGroupByWalletIdRequestModel : IRequest<ResponseModel<IEnumerable<GetAllWalletGroupByWalletIdResponseModel>>>
    {
        public string WalletId { get; set; }
    }
}
