using SPENGO.Domain.Helpers.Interfaces;
using System;

namespace SPENGO.Domain.Helpers.Services
{
    public class GenerateIdHelper : IGenerateIdHelper
    {
        public string Generate()
        {
            try
            {
                var id = Guid.NewGuid().ToString().Replace("-", string.Empty).ToUpper().Substring(0, 10);

                return id;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
