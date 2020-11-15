using MediatR;
using SPENGO.Data.Interfaces;
using SPENGO.Domain.Models.RequestModels.CommandRequestModels;
using SPENGO.Domain.Models.ResponseModel.CommandResponseModels;
using SPENGO.Domain.Models.ResponseModel.Shared;
using System.Threading;
using System.Threading.Tasks;

namespace SPENGO.Domain.Handlers.CommandHandlers
{
    public class DeleteWalletGroupCommandHandler : IRequestHandler<DeleteWalletGroupRequestModel, ResponseModel<DeleteWalletGroupResponseModel>>
    {
        private readonly IWalletGroupRepository walletGroupRepository;

        public DeleteWalletGroupCommandHandler(IWalletGroupRepository walletGroupRepository)
        {
            this.walletGroupRepository = walletGroupRepository;
        }

        private ResponseModel<DeleteWalletGroupResponseModel> responseModel;

        public async Task<ResponseModel<DeleteWalletGroupResponseModel>> Handle(DeleteWalletGroupRequestModel requestModel, CancellationToken cancellationToken)
        {
            var walletGroupModel = await walletGroupRepository.GetByIdAsync(requestModel.Id);

            if (walletGroupModel != null)
            {
                await walletGroupRepository.DeleteAsync(walletGroupModel);

                responseModel = new ResponseModel<DeleteWalletGroupResponseModel>
                {
                    IsValid = true,
                    ErrorMessage = null,
                    Data = null
                };
            }
            else
            {
                responseModel = new ResponseModel<DeleteWalletGroupResponseModel>
                {
                    IsValid = false,
                    ErrorMessage = "Invalid WalletGroup Id.",
                    Data = null
                };
            }

            return responseModel;
        }
    }
}
