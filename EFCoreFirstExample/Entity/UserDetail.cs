using System.ComponentModel.DataAnnotations;

namespace EFCoreFirstExample.Entity
{
    public class UserDetail
    {
        [Key]
        public int UserDetailId { get; set; }
        public string Avatar { get; set; } = string.Empty;
        public int Age { get; set; } = 0;
        public DateTimeOffset Birthday { get; set; }

        //Khóa ngoại để thể hiện  mối quan hệ 1-1 với User
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}