using System.ComponentModel.DataAnnotations;

namespace DbExample.Models
{
    public class BankAccount
    {
        [Key]
        public Guid Id { get; set; }
        public string BankName { get; set; }
        public string AccountId { get; set; }
        public string AccountType { get; set; }
    }
}
