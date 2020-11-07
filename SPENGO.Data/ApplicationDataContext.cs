using Microsoft.EntityFrameworkCore;
using SPENGO.Data.Models;

namespace SPENGO.Data
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<WalletModel> Wallets { get; set; }
    }
}
