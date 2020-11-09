using Microsoft.EntityFrameworkCore;
using SPENGO.Data.Interfaces;
using SPENGO.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPENGO.Data.Repositories
{
    public class WalletRepository : IWalletRepository
    {
        private readonly ApplicationDataContext applicationDataContext;

        public WalletRepository(ApplicationDataContext applicationDataContext)
        {
            this.applicationDataContext = applicationDataContext;
        }

        public async Task<IEnumerable<WalletModel>> GetAllAsync()
        {
            try
            {
                var wallets = await applicationDataContext.Wallets.OrderBy(w => w.StartDate).ToListAsync();

                return wallets;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<WalletModel> GetByIdAsync(string id)
        {
            try
            {
                var wallet = await applicationDataContext.Wallets.FindAsync(id);

                if (wallet != null)
                {
                    applicationDataContext.Entry(wallet).State = EntityState.Detached;
                }

                return wallet;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<string> AddAsync(WalletModel walletModel)
        {
            try
            {
                var addResult = await applicationDataContext.Wallets.AddAsync(walletModel);

                await applicationDataContext.SaveChangesAsync();

                var walletId = addResult.Entity.Id;

                return walletId;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task UpdateAsync(WalletModel walletModel)
        {
            try
            {
                applicationDataContext.Wallets.Update(walletModel);

                await applicationDataContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task DeleteAsync(WalletModel walletModel)
        {
            try
            {
                applicationDataContext.Wallets.Remove(walletModel);

                await applicationDataContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
