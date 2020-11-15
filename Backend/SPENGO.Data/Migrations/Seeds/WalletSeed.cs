using Microsoft.EntityFrameworkCore;
using SPENGO.Data.Models;
using System;

namespace SPENGO.Data.Migrations.Seeds
{
    public static class WalletSeed
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
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
    }
}
