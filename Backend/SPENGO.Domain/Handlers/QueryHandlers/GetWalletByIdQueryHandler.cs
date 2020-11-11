using AutoMapper;
using MediatR;
using SPENGO.Data.Interfaces;
using SPENGO.Domain.Models.RequestModels.QueryRequestModels;
using SPENGO.Domain.Models.ResponseModel.QueryResponseModels;
using SPENGO.Domain.Models.ResponseModel.Shared;
using System.Threading;
using System.Threading.Tasks;

namespace SPENGO.Domain.Handlers.QueryHandlers
{
    public class GetWalletByIdQueryHandler : IRequestHandler<GetWalletByIdRequestModel, ResponseModel<GetWalletByIdResponseModel>>
    {
        private readonly IWalletRepository walletRepository;
        private readonly IMapper mapper;

        public GetWalletByIdQueryHandler(IWalletRepository walletRepository, IMapper mapper)
        {
            this.walletRepository = walletRepository;
            this.mapper = mapper;
        }

        private ResponseModel<GetWalletByIdResponseModel> responseModel;

        public async Task<ResponseModel<GetWalletByIdResponseModel>> Handle(GetWalletByIdRequestModel requestModel, CancellationToken cancellationToken)
        {
            var walletModel = await walletRepository.GetByIdAsync(requestModel.Id);

            var getWalletByIdResponseModel = mapper.Map<GetWalletByIdResponseModel>(walletModel);

            if (getWalletByIdResponseModel != null)
            {
                responseModel = new ResponseModel<GetWalletByIdResponseModel>
                {
                    IsValid = true,
                    ErrorMessage = null,
                    Data = getWalletByIdResponseModel
                };
            }
            else
            {
                responseModel = new ResponseModel<GetWalletByIdResponseModel>
                {
                    IsValid = false,
                    ErrorMessage = "Invalid Wallet Id.",
                    Data = null
                };
            }

            return responseModel;
        }
    }
}
