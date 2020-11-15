using AutoMapper;
using MediatR;
using SPENGO.Data.Interfaces;
using SPENGO.Data.Models;
using SPENGO.Domain.Helpers.Interfaces;
using SPENGO.Domain.Models.ResponseModel.CommandResponseModels;
using SPENGO.Domain.Models.ResponseModel.Shared;
using System.Threading;
using System.Threading.Tasks;

namespace SPENGO.Domain.Handlers.CommandHandlers
{
    public class AddWalletGroupItemCommandHandler : IRequestHandler<AddWalletGroupItemRequestModel, ResponseModel<AddWalletGroupItemResponseModel>>
    {
        private readonly IWalletGroupItemRepository walletGroupItemRepository;
        private readonly IWalletGroupRepository walletGroupRepository;
        private readonly IMapper mapper;
        private readonly IGenerateIdHelper generateIdHelper;

        public AddWalletGroupItemCommandHandler(IWalletGroupItemRepository walletGroupItemRepository, IWalletGroupRepository walletGroupRepository, IMapper mapper, IGenerateIdHelper generateIdHelper)
        {
            this.walletGroupItemRepository = walletGroupItemRepository;
            this.walletGroupRepository = walletGroupRepository;
            this.mapper = mapper;
            this.generateIdHelper = generateIdHelper;
        }

        private ResponseModel<AddWalletGroupItemResponseModel> responseModel;

        public async Task<ResponseModel<AddWalletGroupItemResponseModel>> Handle(AddWalletGroupItemRequestModel requestModel, CancellationToken cancellationToken)
        {
            var walletGroupExists = await walletGroupRepository.GetByIdAsync(requestModel.WalletGroupId) != null;

            if (walletGroupExists == true)
            {
                var walletGroupItemModel = mapper.Map<WalletGroupItemModel>(requestModel);

                walletGroupItemModel.Id = generateIdHelper.Generate();

                var addedId = await walletGroupItemRepository.AddAsync(walletGroupItemModel);

                responseModel = new ResponseModel<AddWalletGroupItemResponseModel>
                {
                    IsValid = true,
                    ErrorMessage = null,
                    Data = new AddWalletGroupItemResponseModel
                    {
                        Id = addedId
                    }
                };
            }
            else
            {
                responseModel = new ResponseModel<AddWalletGroupItemResponseModel>
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
