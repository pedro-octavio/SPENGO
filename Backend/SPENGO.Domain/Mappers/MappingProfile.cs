using AutoMapper;
using SPENGO.Data.Models;
using SPENGO.Domain.Handlers.CommandHandlers;
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
            CreateMap<AddWalletGroupItemRequestModel, WalletGroupItemModel>();

            CreateMap<UpdateWalletRequestModel, WalletModel>();
            CreateMap<UpdateWalletGroupRequestModel, WalletGroupModel>();
            CreateMap<UpdateWalletGroupItemRequestModel, WalletGroupItemModel>();

            CreateMap<WalletModel, GetAllWalletResponseModel>();
            CreateMap<WalletGroupModel, GetAllWalletGroupByWalletIdResponseModel>();
            CreateMap<WalletGroupItemModel, GetAllWalletGroupItemByWalletGroupIdResponseModel>();

            CreateMap<WalletModel, GetWalletByIdResponseModel>();
        }
    }
}
