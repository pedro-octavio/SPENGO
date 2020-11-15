using AutoMapper;
using MediatR;
using SPENGO.Data.Interfaces;
using SPENGO.Domain.Models.RequestModels.QueryRequestModels;
using SPENGO.Domain.Models.ResponseModel.QueryResponseModels;
using SPENGO.Domain.Models.ResponseModel.Shared;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SPENGO.Domain.Handlers.QueryHandlers
{
    public class GetAllWalletGroupByWalletIdQueryHandler : IRequestHandler<GetAllWalletGroupByWalletIdRequestModel, ResponseModel<IEnumerable<GetAllWalletGroupByWalletIdResponseModel>>>
    {
        private readonly IWalletGroupRepository walletGroupRepository;
        private readonly IWalletRepository walletRepository;
        private readonly IMapper mapper;

        public GetAllWalletGroupByWalletIdQueryHandler(IWalletGroupRepository walletGroupRepository, IWalletRepository walletRepository, IMapper mapper)
        {
            this.walletGroupRepository = walletGroupRepository;
            this.walletRepository = walletRepository;
            this.mapper = mapper;
        }

        private ResponseModel<IEnumerable<GetAllWalletGroupByWalletIdResponseModel>> responseModel;

        public async Task<ResponseModel<IEnumerable<GetAllWalletGroupByWalletIdResponseModel>>> Handle(GetAllWalletGroupByWalletIdRequestModel requestModel, CancellationToken cancellationToken)
        {
            var walletExists = await walletRepository.GetByIdAsync(requestModel.WalletId) != null;

            if (walletExists == true)
            {
                var walletGroupsModel = await walletGroupRepository.GetAllByWalletIdAsync(requestModel.WalletId);

                var getAllWalletGroupsResponseModel = mapper.Map<IEnumerable<GetAllWalletGroupByWalletIdResponseModel>>(walletGroupsModel);

                responseModel = new ResponseModel<IEnumerable<GetAllWalletGroupByWalletIdResponseModel>>
                {
                    IsValid = true,
                    ErrorMessage = null,
                    Data = getAllWalletGroupsResponseModel
                };
            }
            else
            {
                responseModel = new ResponseModel<IEnumerable<GetAllWalletGroupByWalletIdResponseModel>>
                {
                    IsValid = false,
                    ErrorMessage = "Invalid Wallet Id.",
                    Data = null
                };
            }

            return responseModel;
        }
    }
}
