using MediatR;
using SPENGO.Domain.Models.RequestModels.CommandRequestModels;
using SPENGO.Domain.Models.ResponseModel.CommandResponseModels;
using SPENGO.Domain.Models.ResponseModel.Shared;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SPENGO.Domain.Handlers.CommandHandlers
{
    public class UpdateWalletCommandHandler : IRequestHandler<UpdateWalletRequestModel, ReponseModel<UpdateWalletResponseModel>>
    {
        public async Task<ReponseModel<UpdateWalletResponseModel>> Handle(UpdateWalletRequestModel request, CancellationToken cancellationToken)
        {
            try
            {
                var responseModel = new ReponseModel<UpdateWalletResponseModel>
                {
                    ErrorMessage = null,
                    IsValid = true,
                    Data = new UpdateWalletResponseModel
                    {

                    }
                };

                return responseModel;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
