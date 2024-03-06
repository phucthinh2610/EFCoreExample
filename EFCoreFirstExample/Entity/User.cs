using System.ComponentModel.DataAnnotations;

namespace EFCoreFirstExample.Entity
{
    public class User
    {

        [Key]
        public int UserId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool EmailConfirmed { get; set; } = false;
        
        //navigation 1-1
        public UserDetail? UserDetail { get; set; }

        //navigation 1-n
        public ICollection<UserOrder> Orders { get; set; }

    }
}