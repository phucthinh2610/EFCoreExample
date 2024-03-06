

using System.ComponentModel.DataAnnotations;

namespace EFCoreFirstExample.Entity
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;  
        public decimal Price { get; set; }
        //deciaml được sử dụng khi chúng ta cần xử lý với các giá trị số thập phân như giá cả sản phẩm,giữ đc chính xác số thập phân, ngăn chặn lối làm tròn trong các phép tính 
        // Ví dụ : decimal Price = 19.99M
        // int được sử dụng khi giá của sản phẩm được biểu diễn dưới dạng số nguyên và không cần xử lý số thập phân
        // Ví dụ : int Price = 1999
            public string Category { get; set; } = string.Empty;
            public string Manufacturer { get; set; } = string.Empty;
            public DateTimeOffset CreationDate { get;set;}
            public DateTimeOffset LastModifiedDate { get; set; }
            public ICollection<UserOrderProduct> UserOrderProducts { get; set; }
    }
}
