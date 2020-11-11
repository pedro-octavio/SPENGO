using System;

namespace SPENGO.Domain.Models.ResponseModel.QueryResponseModels
{
    public class GetAllWalletResponseModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
