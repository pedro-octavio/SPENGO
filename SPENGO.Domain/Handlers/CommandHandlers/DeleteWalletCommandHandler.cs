using MediatR;
using SPENGO.Domain.Models.RequestModels.CommandRequestModels;
using SPENGO.Domain.Models.ResponseModel.CommandResponseModels;
using SPENGO.Domain.Models.ResponseModel.Shared;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SPENGO.Domain.Handlers.CommandHandlers
{
    public class DeleteWalletCommandHandler : IRequestHandler<DeleteWalletRequestModel, ReponseModel<DeleteWalletResponseModel>>
    {
        public async Task<ReponseModel<DeleteWalletResponseModel>> Handle(DeleteWalletRequestModel request, CancellationToken cancellationToken)
        {
            try
            {
                var responseModel = new ReponseModel<DeleteWalletResponseModel>
                {
                    ErrorMessage = null,
                    IsValid = true,
                    Data = new DeleteWalletResponseModel
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
