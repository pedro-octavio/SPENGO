using Microsoft.EntityFrameworkCore;
using SPENGO.Data.Models;
using System;

namespace SPENGO.Data
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
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

            modelBuilder.Entity<WalletModel>()
                .HasData(
                new WalletModel
                {
                    Id = "A01HX730QL",
                    Name = "January Wallet",
                    StartDate = DateTime.ParseExact("01/01/2020", "dd/MM/yyyy", null),
                    EndDate = DateTime.ParseExact("31/01/2020", "dd/MM/yyyy", null)
                },
                new WalletModel
                {
                    Id = "3HA0LXMQ20",
                    Name = "February Wallet",
                    StartDate = DateTime.ParseExact("01/02/2020", "dd/MM/yyyy", null),
                    EndDate = DateTime.ParseExact("29/02/2020", "dd/MM/yyyy", null)
                });
        }

        public DbSet<WalletModel> Wallets { get; set; }
    }
}
