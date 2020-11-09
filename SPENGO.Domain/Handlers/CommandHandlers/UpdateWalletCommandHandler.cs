using AutoMapper;
using MediatR;
using SPENGO.Data.Interfaces;
using SPENGO.Data.Models;
using SPENGO.Domain.Models.RequestModels.CommandRequestModels;
using SPENGO.Domain.Models.ResponseModel.CommandResponseModels;
using SPENGO.Domain.Models.ResponseModel.Shared;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SPENGO.Domain.Handlers.CommandHandlers
{
    public class UpdateWalletCommandHandler : IRequestHandler<UpdateWalletRequestModel, ResponseModel<UpdateWalletResponseModel>>
    {
        private readonly IWalletRepository walletRepository;
        private readonly IMapper mapper;

        public UpdateWalletCommandHandler(IWalletRepository walletRepository, IMapper mapper)
        {
            this.walletRepository = walletRepository;
            this.mapper = mapper;
        }

        private ResponseModel<UpdateWalletResponseModel> responseModel;

        public async Task<ResponseModel<UpdateWalletResponseModel>> Handle(UpdateWalletRequestModel requestModel, CancellationToken cancellationToken)
        {
            try
            {
                var walletModel = mapper.Map<WalletModel>(requestModel);

                var walletExist = await walletRepository.GetByIdAsync(walletModel.Id);

                if (walletExist != null)
                {
                    await walletRepository.UpdateAsync(walletModel);

                    responseModel = new ResponseModel<UpdateWalletResponseModel>
                    {
                        IsValid = true,
                        ErrorMessage = null,
                        Data = null
                    };
                }
                else
                {
                    responseModel = new ResponseModel<UpdateWalletResponseModel>
                    {
                        IsValid = false,
                        ErrorMessage = "Invalid Wallet Id.",
                        Data = null
                    };
                }
            }
            catch (Exception ex)
            {
                responseModel = new ResponseModel<UpdateWalletResponseModel>
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
