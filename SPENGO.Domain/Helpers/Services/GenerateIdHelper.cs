using SPENGO.Domain.Helpers.Interfaces;
using System;

namespace SPENGO.Domain.Helpers.Services
{
    public class GenerateIdHelper : IGenerateIdHelper
    {
        public string Generate()
        {
            var id = Guid.NewGuid().ToString().Replace("-", string.Empty).ToUpper().Substring(0, 10);

            return id;
        }
    }
}
