﻿using MediatR;
using SPENGO.Domain.Models.ResponseModel.QueryResponseModels;
using SPENGO.Domain.Models.ResponseModel.Shared;
using System.Collections.Generic;

namespace SPENGO.Domain.Models.RequestModels.QueryRequestModels
{
    public class GetAllWalletGroupItemByWalletGroupIdRequestModel : IRequest<ResponseModel<IEnumerable<GetAllWalletGroupItemByWalletGroupIdResponseModel>>>
    {
        public string WalletGroupId { get; set; }
    }
}
