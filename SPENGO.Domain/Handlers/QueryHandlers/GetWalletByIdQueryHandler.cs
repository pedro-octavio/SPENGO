using MediatR;
using SPENGO.Domain.Models.RequestModels.QueryRequestModels;
using SPENGO.Domain.Models.ResponseModel.QueryResponseModels;
using SPENGO.Domain.Models.ResponseModel.Shared;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SPENGO.Domain.Handlers.QueryHandlers
{
    public class GetWalletByIdQueryHandler : IRequestHandler<GetWalletByIdRequestModel, ReponseModel<GetWalletByIdResponseModel>>
    {
        public async Task<ReponseModel<GetWalletByIdResponseModel>> Handle(GetWalletByIdRequestModel request, CancellationToken cancellationToken)
        {
            try
            {
                var responseModel = new ReponseModel<GetWalletByIdResponseModel>
                {
                    ErrorMessage = null,
                    IsValid = true,
                    Data = new GetWalletByIdResponseModel
                    {
                        Id = "ns9q0alzp1",
                        Name = "January Wallet",
                        EndDate = DateTime.Now,
                        StartDate = DateTime.Now
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
