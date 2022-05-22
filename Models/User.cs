using System.ComponentModel.DataAnnotations;

namespace DbExample.Models
{
    public class User
    {
        [Key]
        public int Id {     get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
      



    }
}
