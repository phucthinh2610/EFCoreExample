//Bài tập 1 : Tạo thêm UserOrder với mối quan hệ 1-n : 1 user có nhiều đơn hàng
//Tạo thêm  Product : 1 table bình thường
// Tạo bảng UserOrderProduct ( giống bảng product , nhưng lại có thêm quantity,note,discount) quan hệ 1-n với UserOrder




using EFCoreFirstExample;
using EFCoreFirstExample.Entity;
using EFCoreFirstExample.Migrations;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Xml.Linq;

using (EFCoreFirstExampleDBContext context = new())
{
    //dummy data User và UserDeatil
    Random random = new Random();
    for (int i = 0; i < 1000; i++)
    {
        
        int UserId = random.Next(1000, 9999);
        string email = $"dummy.{UserId}@example.com";
        string password = RandomPassword();
        bool emailconfirmed = random.Next(2) == 0;
        string name = GetRandomName();
        int age = random.Next(18, 65);
        List<User> users = context.Users.ToList();

        User user = new()
        {
            UserId = UserId,
            Email = email,
            EmailConfirmed = false,
            Password = password,
            Name = name,
            UserDetail = new()
           {
               UserDetailId = UserId,
               Age = age,
               UserId = UserId,
            }
       };
        context.Users.Add(user);
        context.SaveChanges();
        Console.WriteLine("Inserted Name  : " + user.Name);
    }

    //dummy data Product 
    
    for (int i = 0; i < 1000; i++)
    {
       
        int Id = random.Next(1000, 9999);
        string name = RandomName();
        string description = RandomDescription();
        decimal price = (decimal)random.NextDouble() * 1000;
        string category = GetRandomCategory();
        string manufacturer = GetRandomManufacturer();
        DateTimeOffset creationdate = DateTimeOffset.UtcNow.AddDays(-random.Next(1, 365));
        DateTimeOffset LastModifiedDate = creationdate.AddDays(random.Next(1, 30));
        List<Product> products = context.Products.ToList();

        Product product = new()
        {
            Id = Id,
            Name = name,
            Description = description,
            Price = price,
            Category = category,
            Manufacturer = manufacturer,
            CreationDate = creationdate,
            LastModifiedDate = LastModifiedDate
        };
        context.Products.Add(product);
        context.SaveChanges();
        Console.WriteLine("Inserted Product  : " + product.Name);
    }
    //}

    // dummy  data UserOrder and UserOrderProduct   
    for (int i = 0; i < 1000; i++)
    {
        UserOrder userOrder = new UserOrder
        {
            UserOrderId = i + 1,
            OrderName = $"Order {i + 1}",
            OrderDate = DateTimeOffset.UtcNow.AddDays(-random.Next(1, 365)),
            OrderStatus = GetRandomOrderStatus(),
            TotalAmount = CalculateTotalAmount(),
            UserId = random.Next(1000, 9999)
        };
        context.UserOrders.Add(userOrder);

        int productId = random.Next(1000, 9999);
        int quantity = random.Next(1, 5);
        decimal discount = (decimal)random.NextDouble() * 100;
        string note = $"Note for Order {userOrder.UserOrderId}";

        UserOrderProduct userOrderProduct = new UserOrderProduct
        {
            OrderId = userOrder.UserOrderId,
            ProductId = productId,
            Quantity = quantity,
            Discount = discount,
            Note = note,
            CreationDate = userOrder.OrderDate,
            LastModifiedDate = userOrder.OrderDate
        };

        context.UserOrderProducts.Add(userOrderProduct);
    }

    context.SaveChanges();
}


    
//dummy name của table User và UserDeatil
static string GetRandomName()
{
    string[] names = { "Jonh", "Jane", "Jessica", "Jule", "Juventus", "Jully" };
    Random random = new Random ();
    return names[random.Next (names.Length)];   
}

//dummy password của table User và UserDeatil
static string RandomPassword()
{
    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    var random = new Random();
    var password = new string(Enumerable.Repeat(chars, 8)
        .Select(s => s[random.Next(s.Length)]).ToArray());
    return password;
}

//dummy name của table Product 
static string RandomName()
{
    string[] names = { "Máy Lạnh ", "Áo Thun", "Máy Cắt Cỏ", "Đèn", "Nhật Ký Trong Tù" };
    Random random = new Random();
    return names[random.Next(names.Length)];
}

//dummy description của table Product
static string RandomDescription()
{
    string[] descriptions = {
            "Mô tả sản phẩm 1",
            "Sản phẩm chất lượng cao với thiết kế hiện đại",
            "Được làm từ nguyên liệu tự nhiên",
            "Sản phẩm tiện ích cho cuộc sống hàng ngày",
            "Thích hợp cho mọi đối tượng sử dụng",
            "Chất liệu bền đẹp và dễ dàng vệ sinh",
            "Đảm bảo an toàn và độ tin cậy",
            "Sản phẩm được đánh giá cao từ khách hàng"
     };
    Random random = new Random();
    return descriptions[random.Next(descriptions.Length)];
 }

//dummy category của table Product
static string GetRandomCategory()
{
    string[] categories = { "Electronics", "Clothing", "Home and Garden", "Books" };
    Random random = new Random();
    return categories[random.Next(categories.Length)];
}

//dummy manufacturer của table Product
static string GetRandomManufacturer()
{
    string[] manufacturers = { "Manufacturer A", "Manufacturer B", "Manufacturer C", "Manufacturer D", "Manufacturer E" };
    Random random = new Random();
    return manufacturers[random.Next(manufacturers.Length)];
}

//dummy CalculateTotalAmount của table UserOrder
static decimal CalculateTotalAmount()
{
    Random random = new Random();
    return (decimal)random.NextDouble() * 1000;
}

//dummy GetRandomOrderStatus của table UserOrder
static string GetRandomOrderStatus()
{
    string[] statuses = { "Pending", "Processing", "Shipped", "Delivered" };
    Random random = new Random();
    return statuses[random.Next(statuses.Length)];
}



