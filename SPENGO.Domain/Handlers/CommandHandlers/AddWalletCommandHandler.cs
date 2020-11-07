using MediatR;
using SPENGO.Domain.Models.RequestModels.CommandRequestModels;
using SPENGO.Domain.Models.ResponseModel.CommandResponseModels;
using SPENGO.Domain.Models.ResponseModel.Shared;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SPENGO.Domain.Handlers.CommandHandlers
{
    public class AddWalletCommandHandler : IRequestHandler<AddWalletRequestModel, ReponseModel<AddWalletResponseModel>>
    {
        public async Task<ReponseModel<AddWalletResponseModel>> Handle(AddWalletRequestModel request, CancellationToken cancellationToken)
        {
            try
            {
                var responseModel = new ReponseModel<AddWalletResponseModel>
                {
                    ErrorMessage = null,
                    IsValid = true,
                    Data = new AddWalletResponseModel
                    {
                        Id = "sgq81mzla0"
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
