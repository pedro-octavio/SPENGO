using Microsoft.EntityFrameworkCore;
using SPENGO.Data.Models;

namespace SPENGO.Data.Migrations.Seeds
{
    public static class WalletGroupItemSeed
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WalletGroupItemModel>()
                .HasData(
                new WalletGroupItemModel
                {
                    Id = "ZHA820PLDS",
                    WalletGroupId = "KS01PWIZMA",
                    Name = "Salary",
                    Type = 1,
                    Value = 2000
                },
                new WalletGroupItemModel
                {
                    Id = "0PAGC73M1L",
                    WalletGroupId = "KS01PWIZMA",
                    Name = "Freelancer",
                    Type = 1,
                    Value = 300
                },
                new WalletGroupItemModel
                {
                    Id = "PMJG53ST8Z",
                    WalletGroupId = "LPQ83BAZ01",
                    Name = "Food",
                    Type = 0,
                    Value = 450
                },
                new WalletGroupItemModel
                {
                    Id = "XUS810PWLR",
                    WalletGroupId = "LPQ83BAZ01",
                    Name = "Rent",
                    Type = 0,
                    Value = 400
                },
                new WalletGroupItemModel
                {
                    Id = "P84MXGA0W3",
                    WalletGroupId = "LPQ83BAZ01",
                    Name = "Gasoline",
                    Type = 0,
                    Value = 200
                },
                new WalletGroupItemModel
                {
                    Id = "4HF8Q01LSZ",
                    WalletGroupId = "JS910APZLV",
                    Name = "Fast Food",
                    Type = 0,
                    Value = 20
                },
                new WalletGroupItemModel
                {
                    Id = "MPQ02GR7Z9",
                    WalletGroupId = "JS910APZLV",
                    Name = "Streaming Services",
                    Type = 0,
                    Value = 80
                },
                new WalletGroupItemModel
                {
                    Id = "LPQ74GZ910",
                    WalletGroupId = "OX9Q02L1N7",
                    Name = "Salary",
                    Type = 1,
                    Value = 2000
                },
                new WalletGroupItemModel
                {
                    Id = "OR820XJAY2",
                    WalletGroupId = "OX9Q02L1N7",
                    Name = "Freelancer",
                    Type = 1,
                    Value = 480
                },
                new WalletGroupItemModel
                {
                    Id = "SP8W63GCJA",
                    WalletGroupId = "MLA930DHZT",
                    Name = "Food",
                    Type = 0,
                    Value = 380
                },
                new WalletGroupItemModel
                {
                    Id = "MLA830DGZT",
                    WalletGroupId = "MLA930DHZT",
                    Name = "Rent",
                    Type = 0,
                    Value = 400
                },
                new WalletGroupItemModel
                {
                    Id = "KLA940CHAQ",
                    WalletGroupId = "MLA930DHZT",
                    Name = "Gasoline",
                    Type = 0,
                    Value = 220
                },
                new WalletGroupItemModel
                {
                    Id = "HW630MAQ12",
                    WalletGroupId = "A02PLCGAYQ",
                    Name = "Fast Food",
                    Type = 0,
                    Value = 12
                },
                new WalletGroupItemModel
                {
                    Id = "ZKSP04GF8A",
                    WalletGroupId = "A02PLCGAYQ",
                    Name = "Streaming Services",
                    Type = 0,
                    Value = 80
                }
                );
        }
    }
}
