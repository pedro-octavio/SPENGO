using Microsoft.EntityFrameworkCore;
using SPENGO.Data.Migrations.Seeds;
using SPENGO.Data.Migrations.TableConfigurations;
using SPENGO.Data.Migrations.Tables;
using SPENGO.Data.Models;

namespace SPENGO.Data
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            WalletTable.Configure(modelBuilder);
            WalletSeed.Configure(modelBuilder);

            WalletGroupTable.Configure(modelBuilder);
            WalletGroupSeed.Configure(modelBuilder);

            WalletGroupItemTable.Configure(modelBuilder);
            WalletGroupItemSeed.Configure(modelBuilder);
        }

        public DbSet<WalletModel> Wallets { get; set; }
        public DbSet<WalletGroupModel> WalletGroups { get; set; }
        public DbSet<WalletGroupItemModel> WalletGroupItems { get; set; }
    }
}
