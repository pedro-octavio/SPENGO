using Microsoft.EntityFrameworkCore;
using SPENGO.Data.Models;

namespace SPENGO.Data.Migrations.Tables
{
    public static class WalletGroupItemTable
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WalletGroupItemModel>()
                .Property(x => x.Id)
                .HasMaxLength(10)
                .IsRequired();

            modelBuilder.Entity<WalletGroupItemModel>()
                .Property(x => x.WalletGroupId)
                .HasMaxLength(10)
                .IsRequired();

            modelBuilder.Entity<WalletGroupItemModel>()
                .Property(x => x.Name)
                .HasMaxLength(40)
                .IsRequired();
        }
    }
}
