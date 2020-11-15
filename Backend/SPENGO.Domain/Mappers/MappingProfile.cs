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
            CreateMap<AddWalletGroupRequestModel, WalletGroupModel>();

            CreateMap<UpdateWalletRequestModel, WalletModel>();
            CreateMap<UpdateWalletGroupRequestModel, WalletGroupModel>();

            CreateMap<WalletModel, GetAllWalletResponseModel>();
            CreateMap<WalletGroupModel, GetAllWalletGroupByWalletIdResponseModel>();

            CreateMap<WalletModel, GetWalletByIdResponseModel>();
        }
    }
}
