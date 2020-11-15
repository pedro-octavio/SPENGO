using SPENGO.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SPENGO.Data.Interfaces
{
    public interface IWalletGroupRepository
    {
        Task<IEnumerable<WalletGroupModel>> GetAllByWalletIdAsync(string walletId);
        Task<WalletGroupModel> GetByIdAsync(string id);
        Task<string> AddAsync(WalletGroupModel walletGroupModel);
        Task UpdateAsync(WalletGroupModel walletGroupModel);
        Task DeleteAsync(WalletGroupModel walletGroupModel);
    }
}
