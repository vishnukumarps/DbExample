using DbExample.DB;
using DbExample.Models;
using DbExample.Services.Interfaces;

namespace DbExample.Services
{
    public class BankAccountService : IBankAccountService
    {
        private readonly DemoDbContext dbContext;
        public BankAccountService(DemoDbContext dbContext)
        {
                this.dbContext = dbContext;
        }

        public List<BankAccount> GetAllBankAccounts()
        {
            try
            {
                var all = dbContext.BankAccounts.ToList();
                return all;
            }
            catch (Exception ex)
            {

            }
            return null;
        }

        public BankAccount GetBankAccount(Guid id)
        {
            var bankAccount = dbContext.BankAccounts.Find(id);

            return bankAccount;
        }

        public void Insert(BankAccount bankAccount)
        {
            dbContext.BankAccounts.Add(bankAccount)
        }
    }
}
