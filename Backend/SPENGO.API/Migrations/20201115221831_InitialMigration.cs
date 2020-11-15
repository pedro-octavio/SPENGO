using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SPENGO.API.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WalletGroupItems",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 10, nullable: false),
                    WalletGroupId = table.Column<string>(maxLength: 10, nullable: false),
                    Name = table.Column<string>(maxLength: 40, nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Value = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WalletGroupItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WalletGroups",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 10, nullable: false),
                    WalletId = table.Column<string>(maxLength: 10, nullable: false),
                    Name = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WalletGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wallets",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 10, nullable: false),
                    Name = table.Column<string>(maxLength: 40, nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wallets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "WalletGroupItems",
                columns: new[] { "Id", "Name", "Type", "Value", "WalletGroupId" },
                values: new object[,]
                {
                    { "ZHA820PLDS", "Salary", 1, 2000.0, "KS01PWIZMA" },
                    { "ZKSP04GF8A", "Streaming Services", 0, 80.0, "A02PLCGAYQ" },
                    { "HW630MAQ12", "Fast Food", 0, 12.0, "A02PLCGAYQ" },
                    { "KLA940CHAQ", "Gasoline", 0, 220.0, "MLA930DHZT" },
                    { "SP8W63GCJA", "Food", 0, 380.0, "MLA930DHZT" },
                    { "OR820XJAY2", "Freelancer", 1, 480.0, "OX9Q02L1N7" },
                    { "LPQ74GZ910", "Salary", 1, 2000.0, "OX9Q02L1N7" },
                    { "MLA830DGZT", "Rent", 0, 400.0, "MLA930DHZT" },
                    { "4HF8Q01LSZ", "Fast Food", 0, 20.0, "JS910APZLV" },
                    { "P84MXGA0W3", "Gasoline", 0, 200.0, "LPQ83BAZ01" },
                    { "XUS810PWLR", "Rent", 0, 400.0, "LPQ83BAZ01" },
                    { "PMJG53ST8Z", "Food", 0, 450.0, "LPQ83BAZ01" },
                    { "0PAGC73M1L", "Freelancer", 1, 300.0, "KS01PWIZMA" },
                    { "MPQ02GR7Z9", "Streaming Services", 0, 80.0, "JS910APZLV" }
                });

            migrationBuilder.InsertData(
                table: "WalletGroups",
                columns: new[] { "Id", "Name", "WalletId" },
                values: new object[,]
                {
                    { "KS01PWIZMA", "Gains", "A01HX730QL" },
                    { "LPQ83BAZ01", "Month spents", "A01HX730QL" },
                    { "JS910APZLV", "Extra spents", "A01HX730QL" },
                    { "OX9Q02L1N7", "Gains", "3HA0LXMQ20" },
                    { "MLA930DHZT", "Month spents", "3HA0LXMQ20" },
                    { "A02PLCGAYQ", "Extra spents", "3HA0LXMQ20" }
                });

            migrationBuilder.InsertData(
                table: "Wallets",
                columns: new[] { "Id", "EndDate", "Name", "StartDate" },
                values: new object[,]
                {
                    { "A01HX730QL", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "January Wallet", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "3HA0LXMQ20", new DateTime(2020, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "February Wallet", new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WalletGroupItems");

            migrationBuilder.DropTable(
                name: "WalletGroups");

            migrationBuilder.DropTable(
                name: "Wallets");
        }
    }
}
