using AutoMapper;
using MediatR;
using SPENGO.Data.Interfaces;
using SPENGO.Data.Models;
using SPENGO.Domain.Helpers.Interfaces;
using SPENGO.Domain.Models.RequestModels.CommandRequestModels;
using SPENGO.Domain.Models.ResponseModel.CommandResponseModels;
using SPENGO.Domain.Models.ResponseModel.Shared;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SPENGO.Domain.Handlers.CommandHandlers
{
    public class AddWalletCommandHandler : IRequestHandler<AddWalletRequestModel, ResponseModel<AddWalletResponseModel>>
    {
        private readonly IWalletRepository walletRepository;
        private readonly IMapper mapper;
        private readonly IGenerateIdHelper generateIdHelper;

        public AddWalletCommandHandler(IWalletRepository walletRepository, IMapper mapper, IGenerateIdHelper generateIdHelper)
        {
            this.walletRepository = walletRepository;
            this.mapper = mapper;
            this.generateIdHelper = generateIdHelper;
        }

        private ResponseModel<AddWalletResponseModel> responseModel;

        public async Task<ResponseModel<AddWalletResponseModel>> Handle(AddWalletRequestModel requestModel, CancellationToken cancellationToken)
        {
            try
            {
                var walletModel = mapper.Map<WalletModel>(requestModel);

                walletModel.Id = generateIdHelper.Generate();

                var addedId = await walletRepository.AddAsync(walletModel);

                responseModel = new ResponseModel<AddWalletResponseModel>
                {
                    IsValid = true,
                    ErrorMessage = null,
                    Data = new AddWalletResponseModel
                    {
                        Id = addedId
                    }
                };

                return responseModel;
            }
            catch (Exception ex)
            {
                responseModel = new ResponseModel<AddWalletResponseModel>
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
