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
    public class UpdateWalletGroupCommandHandler : IRequestHandler<UpdateWalletGroupRequestModel, ResponseModel<UpdateWalletGroupResponseModel>>
    {
        private readonly IWalletGroupRepository walletGroupRepository;
        private readonly IMapper mapper;

        public UpdateWalletGroupCommandHandler(IWalletGroupRepository walletGroupRepository, IMapper mapper)
        {
            this.walletGroupRepository = walletGroupRepository;
            this.mapper = mapper;
        }

        private ResponseModel<UpdateWalletGroupResponseModel> responseModel;

        public async Task<ResponseModel<UpdateWalletGroupResponseModel>> Handle(UpdateWalletGroupRequestModel requestModel, CancellationToken cancellationToken)
        {
            var walletExist = await walletGroupRepository.GetByIdAsync(requestModel.Id);

            if (walletExist != null)
            {
                var walletModel = mapper.Map<WalletGroupModel>(requestModel);

                walletModel.WalletId = walletExist.WalletId;

                await walletGroupRepository.UpdateAsync(walletModel);

                responseModel = new ResponseModel<UpdateWalletGroupResponseModel>
                {
                    IsValid = true,
                    ErrorMessage = null,
                    Data = null
                };
            }
            else
            {
                responseModel = new ResponseModel<UpdateWalletGroupResponseModel>
                {
                    IsValid = false,
                    ErrorMessage = "Invalid Wallet Group Id.",
                    Data = null
                };
            }

            return responseModel;
        }
    }
}
