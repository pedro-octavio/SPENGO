using MediatR;
using SPENGO.Domain.Models.RequestModels.QueryRequestModels;
using SPENGO.Domain.Models.ResponseModel.QueryResponseModels;
using SPENGO.Domain.Models.ResponseModel.Shared;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SPENGO.Domain.Handlers.QueryHandlers
{
    public class GetAllWalletQueryHandler : IRequestHandler<GetAllWalletRequestModel, ReponseModel<IEnumerable<GetAllWalletResponseModel>>>
    {
        public async Task<ReponseModel<IEnumerable<GetAllWalletResponseModel>>> Handle(GetAllWalletRequestModel requestModel, CancellationToken cancellationToken)
        {
            try
            {
                var responseModel = new ReponseModel<IEnumerable<GetAllWalletResponseModel>>
                {
                    ErrorMessage = null,
                    IsValid = true,
                    Data = new List<GetAllWalletResponseModel> {
                        new GetAllWalletResponseModel
                        {
                            Id="s73mpq0ax6",
                            Name="January Wallet",
                            EndDate=DateTime.Now,
                            StartDate=DateTime.Now
                        },
                        new GetAllWalletResponseModel
                        {
                            Id="px01ta6c8a",
                            Name="February Wallet",
                            EndDate=DateTime.Now,
                            StartDate=DateTime.Now
                        },
                        new GetAllWalletResponseModel
                        {
                            Id="zpa04hc8q2",
                            Name="March Wallet",
                            EndDate=DateTime.Now,
                            StartDate=DateTime.Now
                        }
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
