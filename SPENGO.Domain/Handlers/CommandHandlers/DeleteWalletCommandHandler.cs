using MediatR;
using SPENGO.Data.Interfaces;
using SPENGO.Domain.Models.RequestModels.CommandRequestModels;
using SPENGO.Domain.Models.ResponseModel.CommandResponseModels;
using SPENGO.Domain.Models.ResponseModel.Shared;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SPENGO.Domain.Handlers.CommandHandlers
{
    public class DeleteWalletCommandHandler : IRequestHandler<DeleteWalletRequestModel, ResponseModel<DeleteWalletResponseModel>>
    {
        private readonly IWalletRepository walletRepository;

        public DeleteWalletCommandHandler(IWalletRepository walletRepository)
        {
            this.walletRepository = walletRepository;
        }

        private ResponseModel<DeleteWalletResponseModel> responseModel;

        public async Task<ResponseModel<DeleteWalletResponseModel>> Handle(DeleteWalletRequestModel requestModel, CancellationToken cancellationToken)
        {
            try
            {
                var walletModel = await walletRepository.GetByIdAsync(requestModel.Id);

                await walletRepository.DeleteAsync(walletModel);

                responseModel = new ResponseModel<DeleteWalletResponseModel>
                {
                    IsValid = true,
                    ErrorMessage = null,
                    Data = null
                };
            }
            catch (Exception ex)
            {
                responseModel = new ResponseModel<DeleteWalletResponseModel>
                {
                    IsValid = false,
                    ErrorMessage = ex.Message,
                    Data = null
                };
            }

            return responseModel;
        }
    }
}
