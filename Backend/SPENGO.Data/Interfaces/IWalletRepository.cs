﻿using SPENGO.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SPENGO.Data.Interfaces
{
    public interface IWalletRepository
    {
        Task<IEnumerable<WalletModel>> GetAllAsync(DateTime? startDate, DateTime? endDate);
        Task<WalletModel> GetByIdAsync(string id);
        Task<string> AddAsync(WalletModel walletModel);
        Task UpdateAsync(WalletModel walletModel);
        Task DeleteAsync(WalletModel walletModel);
    }
}
