using DbExample.Models;
using Microsoft.EntityFrameworkCore;

namespace DbExample.DB
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions<DemoDbContext> options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }


    }
}
