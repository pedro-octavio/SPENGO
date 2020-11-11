using Microsoft.EntityFrameworkCore;
using SPENGO.Data.Migrations.Seeds;
using SPENGO.Data.Migrations.TableConfigurations;
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
            WalletTable.Migration(modelBuilder);
            WalletSeed.Seed(modelBuilder);
        }

        public DbSet<WalletModel> Wallets { get; set; }
    }
}
