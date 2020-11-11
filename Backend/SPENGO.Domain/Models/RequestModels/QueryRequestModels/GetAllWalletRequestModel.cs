using MediatR;
using SPENGO.Domain.Models.ResponseModel.QueryResponseModels;
using SPENGO.Domain.Models.ResponseModel.Shared;
using System;
using System.Collections.Generic;

namespace SPENGO.Domain.Models.RequestModels.QueryRequestModels
{
    public class GetAllWalletRequestModel : IRequest<ResponseModel<IEnumerable<GetAllWalletResponseModel>>>
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
