using EFCoreFirstExample.Entity;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EFCoreFirstExample
{
    public class EFCoreFirstExampleDBContext : DbContext
    {
        private string _ConnectionString = "Host=ep-fancy-heart-a157qb04.ap-southeast-1.aws.neon.tech;Database=excersie1;Username=bimapmap1234567;Password=2BnZHiDhqTI1";
            public DbSet<User> Users { get; set; }
            public DbSet<UserOrder> UserOrders { get; set; }
            public DbSet<Product> Products { get; set; }
            public DbSet<UserOrderProduct> UserOrderProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(_ConnectionString);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Đặt mối quan hệ 1-1
            modelBuilder.Entity<User>()
                .HasOne(a => a.UserDetail)
                .WithOne(a => a.User)
                .HasForeignKey<UserDetail>(a => a.UserId);

            // Đặt  mối quan hệ 1-n giữa User và UserOrder
            modelBuilder.Entity<UserOrder>()
                .HasOne(uo => uo.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(uo => uo.UserId);

            // Đặt mối quan hệ n-n giữa UserOrder và Product thông qua UserOrderProduct
            modelBuilder.Entity<UserOrderProduct>().HasKey(uop => new { uop.UserOrderId, uop.ProductId });
           
            modelBuilder.Entity<UserOrderProduct>()
                .HasOne(uop => uop.UserOrder)
                .WithMany(uo => uo.UserOrderProducts)
                .HasForeignKey(uop => uop.UserOrderId);

            modelBuilder.Entity<UserOrderProduct>()
                .HasOne(uop => uop.Product)
                .WithMany(p => p.UserOrderProducts)
                .HasForeignKey(uop => uop.ProductId);
        }
    }
}
