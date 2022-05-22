using DbExample.Models;

namespace DbExample.Services.Interfaces
{
    public interface IBankAccountService
    {

        public void Insert(BankAccount bankAccount);

        public BankAccount GetBankAccount(Guid id);

        public List<BankAccount> GetAllBankAccounts();
    }
}
