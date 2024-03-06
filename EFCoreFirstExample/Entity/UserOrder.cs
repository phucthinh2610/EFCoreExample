

using System.ComponentModel.DataAnnotations;

namespace EFCoreFirstExample.Entity
{
    public class UserOrder
    {
        [Key]
             public int UserOrderId { get; set; }    
             public string OrderName { get; set; } = string.Empty;
             public DateTimeOffset OrderDate { get; set; }
             public string OrderStatus { get; set; } = string.Empty;
             public decimal TotalAmount { get; set; }

        // Khóa ngoại để thể hiện mối quan hệ  1-n với User
        public int UserId { get; set; }
        public User? User { get; set; }
        public ICollection<UserOrderProduct> UserOrderProducts { get; set; }
    }
}
