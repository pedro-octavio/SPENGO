using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SPENGO.API.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Wallets",
                columns: new[] { "Id", "EndDate", "Name", "StartDate" },
                values: new object[] { "A01HX730QL", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "January Wallet", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Wallets",
                columns: new[] { "Id", "EndDate", "Name", "StartDate" },
                values: new object[] { "3HA0LXMQ20", new DateTime(2020, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "February Wallet", new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Wallets");
        }
    }
}
