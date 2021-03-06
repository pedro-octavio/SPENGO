﻿using MediatR;
using SPENGO.Domain.Models.ResponseModel.QueryResponseModels;
using SPENGO.Domain.Models.ResponseModel.Shared;

namespace SPENGO.Domain.Models.RequestModels.QueryRequestModels
{
    public class GetWalletByIdRequestModel : IRequest<ResponseModel<GetWalletByIdResponseModel>>
    {
        public string Id { get; set; }
    }
}
