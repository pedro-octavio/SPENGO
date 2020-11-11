using AutoMapper;
using MediatR;
using SPENGO.Data.Interfaces;
using SPENGO.Domain.Models.RequestModels.QueryRequestModels;
using SPENGO.Domain.Models.ResponseModel.QueryResponseModels;
using SPENGO.Domain.Models.ResponseModel.Shared;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SPENGO.Domain.Handlers.QueryHandlers
{
    public class GetAllWalletQueryHandler : IRequestHandler<GetAllWalletRequestModel, ResponseModel<IEnumerable<GetAllWalletResponseModel>>>
    {
        private readonly IWalletRepository walletRepository;
        private readonly IMapper mapper;

        public GetAllWalletQueryHandler(IWalletRepository walletRepository, IMapper mapper)
        {
            this.walletRepository = walletRepository;
            this.mapper = mapper;
        }

        private ResponseModel<IEnumerable<GetAllWalletResponseModel>> responseModel;

        public async Task<ResponseModel<IEnumerable<GetAllWalletResponseModel>>> Handle(GetAllWalletRequestModel requestModel, CancellationToken cancellationToken)
        {
            var walletsModel = await walletRepository.GetAllAsync(requestModel.StartDate, requestModel.EndDate);

            var getAllWalletResponseModel = mapper.Map<IEnumerable<GetAllWalletResponseModel>>(walletsModel);

            responseModel = new ResponseModel<IEnumerable<GetAllWalletResponseModel>>
            {
                IsValid = true,
                ErrorMessage = null,
                Data = getAllWalletResponseModel
            };

            return responseModel;
        }
    }
}
