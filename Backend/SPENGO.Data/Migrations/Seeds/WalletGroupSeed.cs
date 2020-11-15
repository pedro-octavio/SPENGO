using Microsoft.EntityFrameworkCore;
using SPENGO.Data.Models;

namespace SPENGO.Data.Migrations.Seeds
{
    public class WalletGroupSeed
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WalletGroupModel>()
                .HasData(
                new WalletGroupModel
                {
                    Id = "KS01PWIZMA",
                    WalletId = "A01HX730QL",
                    Name = "Gains"
                },
                new WalletGroupModel
                {
                    Id = "LPQ83BAZ01",
                    WalletId = "A01HX730QL",
                    Name = "Month spents"
                },
                new WalletGroupModel
                {
                    Id = "JS910APZLV",
                    WalletId = "A01HX730QL",
                    Name = "Extra spents"
                },
                new WalletGroupModel
                {
                    Id = "OX9Q02L1N7",
                    WalletId = "3HA0LXMQ20",
                    Name = "Gains"
                },
                new WalletGroupModel
                {
                    Id = "MLA930DHZT",
                    WalletId = "3HA0LXMQ20",
                    Name = "Month spents"
                },
                new WalletGroupModel
                {
                    Id = "A02PLCGAYQ",
                    WalletId = "3HA0LXMQ20",
                    Name = "Extra spents"
                }
                );
        }
    }
}
