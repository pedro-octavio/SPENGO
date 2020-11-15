using SPENGO.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SPENGO.Data.Interfaces
{
    public interface IWalletGroupItemRepository
    {
        Task<IEnumerable<WalletGroupItemModel>> GetAllByWalletGroupIdAsync(string walletGroupId);
        Task<WalletGroupItemModel> GetByIdAsync(string id);
        Task<string> AddAsync(WalletGroupItemModel walletGroupItemModel);
        Task UpdateAsync(WalletGroupItemModel walletGroupItemModel);
        Task DeleteAsync(WalletGroupItemModel walletGroupItemModel);
    }
}
