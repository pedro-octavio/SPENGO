using AutoMapper;
using SPENGO.Data.Models;
using SPENGO.Domain.Models.RequestModels.CommandRequestModels;
using SPENGO.Domain.Models.ResponseModel.QueryResponseModels;

namespace SPENGO.Domain.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AddWalletRequestModel, WalletModel>();
            CreateMap<UpdateWalletRequestModel, WalletModel>();

            CreateMap<WalletModel, GetAllWalletResponseModel>();
            CreateMap<WalletModel, GetWalletByIdResponseModel>();
        }
    }
}
