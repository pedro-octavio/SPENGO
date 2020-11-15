﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SPENGO.Data;

namespace SPENGO.API.Migrations
{
    [DbContext(typeof(ApplicationDataContext))]
    partial class ApplicationDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SPENGO.Data.Models.WalletGroupItemModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasMaxLength(40);

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<double>("Value")
                        .HasColumnType("double");

                    b.Property<string>("WalletGroupId")
                        .IsRequired()
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("WalletGroupItems");

                    b.HasData(
                        new
                        {
                            Id = "ZHA820PLDS",
                            Name = "Salary",
                            Type = 1,
                            Value = 2000.0,
                            WalletGroupId = "KS01PWIZMA"
                        },
                        new
                        {
                            Id = "0PAGC73M1L",
                            Name = "Freelancer",
                            Type = 1,
                            Value = 300.0,
                            WalletGroupId = "KS01PWIZMA"
                        },
                        new
                        {
                            Id = "PMJG53ST8Z",
                            Name = "Food",
                            Type = 0,
                            Value = 450.0,
                            WalletGroupId = "LPQ83BAZ01"
                        },
                        new
                        {
                            Id = "XUS810PWLR",
                            Name = "Rent",
                            Type = 0,
                            Value = 400.0,
                            WalletGroupId = "LPQ83BAZ01"
                        },
                        new
                        {
                            Id = "P84MXGA0W3",
                            Name = "Gasoline",
                            Type = 0,
                            Value = 200.0,
                            WalletGroupId = "LPQ83BAZ01"
                        },
                        new
                        {
                            Id = "4HF8Q01LSZ",
                            Name = "Fast Food",
                            Type = 0,
                            Value = 20.0,
                            WalletGroupId = "JS910APZLV"
                        },
                        new
                        {
                            Id = "MPQ02GR7Z9",
                            Name = "Streaming Services",
                            Type = 0,
                            Value = 80.0,
                            WalletGroupId = "JS910APZLV"
                        },
                        new
                        {
                            Id = "LPQ74GZ910",
                            Name = "Salary",
                            Type = 1,
                            Value = 2000.0,
                            WalletGroupId = "OX9Q02L1N7"
                        },
                        new
                        {
                            Id = "OR820XJAY2",
                            Name = "Freelancer",
                            Type = 1,
                            Value = 480.0,
                            WalletGroupId = "OX9Q02L1N7"
                        },
                        new
                        {
                            Id = "SP8W63GCJA",
                            Name = "Food",
                            Type = 0,
                            Value = 380.0,
                            WalletGroupId = "MLA930DHZT"
                        },
                        new
                        {
                            Id = "MLA830DGZT",
                            Name = "Rent",
                            Type = 0,
                            Value = 400.0,
                            WalletGroupId = "MLA930DHZT"
                        },
                        new
                        {
                            Id = "KLA940CHAQ",
                            Name = "Gasoline",
                            Type = 0,
                            Value = 220.0,
                            WalletGroupId = "MLA930DHZT"
                        },
                        new
                        {
                            Id = "HW630MAQ12",
                            Name = "Fast Food",
                            Type = 0,
                            Value = 12.0,
                            WalletGroupId = "A02PLCGAYQ"
                        },
                        new
                        {
                            Id = "ZKSP04GF8A",
                            Name = "Streaming Services",
                            Type = 0,
                            Value = 80.0,
                            WalletGroupId = "A02PLCGAYQ"
                        });
                });

            modelBuilder.Entity("SPENGO.Data.Models.WalletGroupModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasMaxLength(40);

                    b.Property<string>("WalletId")
                        .IsRequired()
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("WalletGroups");

                    b.HasData(
                        new
                        {
                            Id = "KS01PWIZMA",
                            Name = "Gains",
                            WalletId = "A01HX730QL"
                        },
                        new
                        {
                            Id = "LPQ83BAZ01",
                            Name = "Month spents",
                            WalletId = "A01HX730QL"
                        },
                        new
                        {
                            Id = "JS910APZLV",
                            Name = "Extra spents",
                            WalletId = "A01HX730QL"
                        },
                        new
                        {
                            Id = "OX9Q02L1N7",
                            Name = "Gains",
                            WalletId = "3HA0LXMQ20"
                        },
                        new
                        {
                            Id = "MLA930DHZT",
                            Name = "Month spents",
                            WalletId = "3HA0LXMQ20"
                        },
                        new
                        {
                            Id = "A02PLCGAYQ",
                            Name = "Extra spents",
                            WalletId = "3HA0LXMQ20"
                        });
                });

            modelBuilder.Entity("SPENGO.Data.Models.WalletModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasMaxLength(40);

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Wallets");

                    b.HasData(
                        new
                        {
                            Id = "A01HX730QL",
                            EndDate = new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "January Wallet",
                            StartDate = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = "3HA0LXMQ20",
                            EndDate = new DateTime(2020, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "February Wallet",
                            StartDate = new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
