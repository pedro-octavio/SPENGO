using AutoMapper;
using MediatR;
using SPENGO.Data.Interfaces;
using SPENGO.Data.Models;
using SPENGO.Domain.Helpers.Interfaces;
using SPENGO.Domain.Models.RequestModels.CommandRequestModels;
using SPENGO.Domain.Models.ResponseModel.CommandResponseModels;
using SPENGO.Domain.Models.ResponseModel.Shared;
using System.Threading;
using System.Threading.Tasks;

namespace SPENGO.Domain.Handlers.CommandHandlers
{
    public class AddWalletGroupCommandHandler : IRequestHandler<AddWalletGroupRequestModel, ResponseModel<AddWalletGroupResponseModel>>
    {
        private readonly IWalletGroupRepository walletGroupRepository;
        private readonly IMapper mapper;
        private readonly IGenerateIdHelper generateIdHelper;

        public AddWalletGroupCommandHandler(IWalletGroupRepository walletGroupRepository, IMapper mapper, IGenerateIdHelper generateIdHelper)
        {
            this.walletGroupRepository = walletGroupRepository;
            this.mapper = mapper;
            this.generateIdHelper = generateIdHelper;
        }

        private ResponseModel<AddWalletGroupResponseModel> responseModel;

        public async Task<ResponseModel<AddWalletGroupResponseModel>> Handle(AddWalletGroupRequestModel requestModel, CancellationToken cancellationToken)
        {
            var walletGroupModel = mapper.Map<WalletGroupModel>(requestModel);

            walletGroupModel.Id = generateIdHelper.Generate();

            var addedId = await walletGroupRepository.AddAsync(walletGroupModel);

            responseModel = new ResponseModel<AddWalletGroupResponseModel>
            {
                IsValid = true,
                ErrorMessage = null,
                Data = new AddWalletGroupResponseModel
                {
                    Id = addedId
                }
            };

            return responseModel;
        }
    }
}
