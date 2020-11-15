using AutoMapper;
using MediatR;
using SPENGO.Data.Interfaces;
using SPENGO.Data.Models;
using SPENGO.Domain.Models.RequestModels.CommandRequestModels;
using SPENGO.Domain.Models.ResponseModel.CommandResponseModels;
using SPENGO.Domain.Models.ResponseModel.Shared;
using System.Threading;
using System.Threading.Tasks;

namespace SPENGO.Domain.Handlers.CommandHandlers
{
    public class UpdateWalletGroupItemCommandHandler : IRequestHandler<UpdateWalletGroupItemRequestModel, ResponseModel<UpdateWalletGroupItemResponseModel>>
    {
        private readonly IWalletGroupItemRepository walletGroupItemRepository;
        private readonly IMapper mapper;

        public UpdateWalletGroupItemCommandHandler(IWalletGroupItemRepository walletGroupItemRepositor, IMapper mapper)
        {
            this.walletGroupItemRepository = walletGroupItemRepositor;
            this.mapper = mapper;
        }

        private ResponseModel<UpdateWalletGroupItemResponseModel> responseModel;

        public async Task<ResponseModel<UpdateWalletGroupItemResponseModel>> Handle(UpdateWalletGroupItemRequestModel requestModel, CancellationToken cancellationToken)
        {
            var walletGroupItemExists = await walletGroupItemRepository.GetByIdAsync(requestModel.Id);

            if (walletGroupItemExists != null)
            {
                var walletGroupItemModel = mapper.Map<WalletGroupItemModel>(requestModel);

                walletGroupItemModel.WalletGroupId = walletGroupItemExists.WalletGroupId;

                await walletGroupItemRepository.UpdateAsync(walletGroupItemModel);

                responseModel = new ResponseModel<UpdateWalletGroupItemResponseModel>
                {
                    IsValid = true,
                    ErrorMessage = null,
                    Data = null
                };
            }
            else
            {
                responseModel = new ResponseModel<UpdateWalletGroupItemResponseModel>
                {
                    IsValid = false,
                    ErrorMessage = "Invalid WalletGroupItem Id.",
                    Data = null
                };
            }

            return responseModel;
        }
    }
}
