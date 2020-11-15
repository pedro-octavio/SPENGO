using Microsoft.EntityFrameworkCore;
using SPENGO.Data.Interfaces;
using SPENGO.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPENGO.Data.Repositories
{
    public class WalletGroupRepository : IWalletGroupRepository
    {
        private readonly ApplicationDataContext applicationDataContext;

        public WalletGroupRepository(ApplicationDataContext applicationDataContext)
        {
            this.applicationDataContext = applicationDataContext;
        }

        public async Task<IEnumerable<WalletGroupModel>> GetAllByWalletIdAsync(string walletId)
        {
            var walletGroups = await applicationDataContext.WalletGroups.Where(w => w.WalletId == walletId).OrderBy(w => w.Name).ToListAsync();

            return walletGroups;
        }

        public async Task<WalletGroupModel> GetByIdAsync(string id)
        {
            var walletGroup = await applicationDataContext.WalletGroups.FindAsync(id);

            if (walletGroup != null)
            {
                applicationDataContext.Entry(walletGroup).State = EntityState.Detached;
            }

            return walletGroup;
        }

        public async Task<string> AddAsync(WalletGroupModel walletGroupModel)
        {
            var addResult = await applicationDataContext.WalletGroups.AddAsync(walletGroupModel);

            await applicationDataContext.SaveChangesAsync();

            var walletGroupId = addResult.Entity.Id;

            return walletGroupId;
        }

        public async Task UpdateAsync(WalletGroupModel walletGroupModel)
        {
            applicationDataContext.WalletGroups.Update(walletGroupModel);

            await applicationDataContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(WalletGroupModel walletGroupModel)
        {
            applicationDataContext.WalletGroups.Remove(walletGroupModel);

            await applicationDataContext.SaveChangesAsync();
        }
    }
}
