﻿using Microsoft.EntityFrameworkCore;
using SPENGO.Data.Models;

namespace SPENGO.Data.Migrations.Tables
{
    public static class WalletGroupTable
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WalletGroupModel>()
                .Property(x => x.Id)
                .HasMaxLength(10)
                .IsRequired();

            modelBuilder.Entity<WalletGroupModel>()
                .Property(x => x.WalletId)
                .HasMaxLength(10)
                .IsRequired();

            modelBuilder.Entity<WalletGroupModel>()
                .Property(x => x.Name)
                .HasMaxLength(40)
                .IsRequired();
        }
    }
}
