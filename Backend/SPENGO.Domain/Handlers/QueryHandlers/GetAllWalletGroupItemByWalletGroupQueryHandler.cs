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
    public class GetAllWalletGroupItemByWalletGroupQueryHandler : IRequestHandler<GetAllWalletGroupItemByWalletGroupIdRequestModel, ResponseModel<IEnumerable<GetAllWalletGroupItemByWalletGroupIdResponseModel>>>
    {
        private readonly IWalletGroupItemRepository walletGroupItemRepository;
        private readonly IWalletGroupRepository walletGroupRepository;
        private readonly IMapper mapper;

        public GetAllWalletGroupItemByWalletGroupQueryHandler(IWalletGroupItemRepository walletGroupItemRepository, IWalletGroupRepository walletGroupRepository, IMapper mapper)
        {
            this.walletGroupItemRepository = walletGroupItemRepository;
            this.walletGroupRepository = walletGroupRepository;
            this.mapper = mapper;
        }

        private ResponseModel<IEnumerable<GetAllWalletGroupItemByWalletGroupIdResponseModel>> responseModel;

        public async Task<ResponseModel<IEnumerable<GetAllWalletGroupItemByWalletGroupIdResponseModel>>> Handle(GetAllWalletGroupItemByWalletGroupIdRequestModel requestModel, CancellationToken cancellationToken)
        {
            var walletGroupExists = await walletGroupRepository.GetByIdAsync(requestModel.WalletGroupId) != null;

            if (walletGroupExists == true)
            {
                var walletGroupItemsModel = await walletGroupItemRepository.GetAllByWalletGroupIdAsync(requestModel.WalletGroupId);

                var getAllWalletGroupItemByWalletGroupIdResponseModel = mapper.Map<IEnumerable<GetAllWalletGroupItemByWalletGroupIdResponseModel>>(walletGroupItemsModel);

                responseModel = new ResponseModel<IEnumerable<GetAllWalletGroupItemByWalletGroupIdResponseModel>>
                {
                    IsValid = true,
                    ErrorMessage = null,
                    Data = getAllWalletGroupItemByWalletGroupIdResponseModel
                };
            }
            else
            {
                responseModel = new ResponseModel<IEnumerable<GetAllWalletGroupItemByWalletGroupIdResponseModel>>
                {
                    IsValid = false,
                    ErrorMessage = "Invalid WalletGroupId.",
                    Data = null
                };
            }

            return responseModel;
        }
    }
}
