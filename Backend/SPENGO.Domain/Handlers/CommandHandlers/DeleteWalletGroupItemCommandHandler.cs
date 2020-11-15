using MediatR;
using SPENGO.Data.Interfaces;
using SPENGO.Domain.Models.RequestModels.CommandRequestModels;
using SPENGO.Domain.Models.ResponseModel.CommandResponseModels;
using SPENGO.Domain.Models.ResponseModel.Shared;
using System.Threading;
using System.Threading.Tasks;

namespace SPENGO.Domain.Handlers.CommandHandlers
{
    public class DeleteWalletGroupItemCommandHandler : IRequestHandler<DeleteWalletGroupItemRequestModel, ResponseModel<DeleteWalletGroupItemResponseModel>>
    {
        private readonly IWalletGroupItemRepository walletGroupItemRepository;

        public DeleteWalletGroupItemCommandHandler(IWalletGroupItemRepository walletGroupItemRepository)
        {
            this.walletGroupItemRepository = walletGroupItemRepository;
        }

        private ResponseModel<DeleteWalletGroupItemResponseModel> responseModel;

        public async Task<ResponseModel<DeleteWalletGroupItemResponseModel>> Handle(DeleteWalletGroupItemRequestModel requestModel, CancellationToken cancellationToken)
        {
            var walletGroupItemModel = await walletGroupItemRepository.GetByIdAsync(requestModel.Id);

            if (walletGroupItemModel != null)
            {
                await walletGroupItemRepository.DeleteAsync(walletGroupItemModel);

                responseModel = new ResponseModel<DeleteWalletGroupItemResponseModel>
                {
                    IsValid = true,
                    ErrorMessage = null,
                    Data = null
                };
            }
            else
            {
                responseModel = new ResponseModel<DeleteWalletGroupItemResponseModel>
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
