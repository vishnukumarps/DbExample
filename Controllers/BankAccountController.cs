using DbExample.Models;
using DbExample.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DbExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountController : ControllerBase
    {
        IBankAccountService bankAccountService;
        public BankAccountController(IBankAccountService bankAccountService)
        {
            this.bankAccountService = bankAccountService;
        }


        [HttpGet]
        public List<BankAccount> GetAll()
        {
            var all= bankAccountService.GetAllBankAccounts();
            return all;
        }

        [HttpPost]

        public string Insert(BankAccount bankAccount)
        {

            bankAccountService.Insert(bankAccount);


            return "success";
        }

        [HttpGet]
        public BankAccount GetBankAccount(Guid id)
        {

            var result= bankAccountService.GetBankAccount(id);
            return result;
        }
    }
}
