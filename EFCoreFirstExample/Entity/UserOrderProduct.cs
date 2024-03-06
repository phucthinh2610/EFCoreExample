
// Tạo bảng UserOrderProduct ( giống bảng product , nhưng lại có thêm quantity, note, discount) quan hệ 1-n với UserOrder
using System.ComponentModel.DataAnnotations;

namespace EFCoreFirstExample.Entity
{
    public class UserOrderProduct
    {
        [Key]
        public int OrderId { get; set; }
        public int  Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Manufacturer { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; } 
        public string Note { get; set; } = string.Empty;
        public DateTimeOffset CreationDate { get; set; }
        public DateTimeOffset LastModifiedDate { get; set; }

        // Khóa ngoại để thể hiện mối quan hệ 1-n với Product
        public int ProductId { get; set; }
        public Product? Product { get; set; }

        // Khóa ngoại để thể hiện mối quan hệ 1-n với UserOrder
        public  int UserOrderId { get; set; }
        public UserOrder? UserOrder {  get; set; }
    }
}
