using Microsoft.EntityFrameworkCore;
using SPENGO.Data.Models;

namespace SPENGO.Data.Migrations.TableConfigurations
{
    public static class WalletTable
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WalletModel>()
               .Property(x => x.Id)
               .HasMaxLength(10)
               .IsRequired();

            modelBuilder.Entity<WalletModel>()
                .Property(x => x.Name)
                .HasMaxLength(40)
                .IsRequired();

            modelBuilder.Entity<WalletModel>()
                .Property(x => x.StartDate)
                .IsRequired();

            modelBuilder.Entity<WalletModel>()
                .Property(x => x.EndDate)
                .IsRequired();
        }
    }
}
