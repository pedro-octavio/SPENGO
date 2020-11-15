using Microsoft.EntityFrameworkCore;
using SPENGO.Data.Interfaces;
using SPENGO.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPENGO.Data.Repositories
{
    public class WalletGroupItemRepository : IWalletGroupItemRepository
    {
        private readonly ApplicationDataContext applicationDataContext;

        public WalletGroupItemRepository(ApplicationDataContext applicationDataContext)
        {
            this.applicationDataContext = applicationDataContext;
        }

        public async Task<IEnumerable<WalletGroupItemModel>> GetAllByWalletGroupIdAsync(string walletGroupId)
        {
            var walletGroupItems = await applicationDataContext.WalletGroupItems.Where(w => w.WalletGroupId == walletGroupId).OrderBy(w => w.Name).ToListAsync();

            return walletGroupItems;
        }

        public async Task<WalletGroupItemModel> GetByIdAsync(string id)
        {
            var walletGroupItem = await applicationDataContext.WalletGroupItems.FindAsync(id);

            if (walletGroupItem != null)
            {
                applicationDataContext.Entry(walletGroupItem).State = EntityState.Detached;
            }

            return walletGroupItem;
        }

        public async Task<string> AddAsync(WalletGroupItemModel walletGroupItemModel)
        {
            var addResult = await applicationDataContext.WalletGroupItems.AddAsync(walletGroupItemModel);

            await applicationDataContext.SaveChangesAsync();

            var walletGroupItemId = addResult.Entity.Id;

            return walletGroupItemId;
        }

        public async Task UpdateAsync(WalletGroupItemModel walletGroupItemModel)
        {
            applicationDataContext.WalletGroupItems.Update(walletGroupItemModel);

            await applicationDataContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(WalletGroupItemModel walletGroupItemModel)
        {
            applicationDataContext.WalletGroupItems.Remove(walletGroupItemModel);

            await applicationDataContext.SaveChangesAsync();
        }
    }
}
