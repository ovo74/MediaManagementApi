namespace MediaManagementApi.Models
{
    public class Content
    {
        public int Id { get; set; } // Khóa chính
        public string Title { get; set; } // Tiêu đề của nội dung
        public string FilePath { get; set; } // Đường dẫn đến tệp (video, ảnh, URL)
        public string ContentType { get; set; } // Loại nội dung: "video", "image", hoặc "url"
        public int UserId { get; set; } // Khóa ngoại đến User (để biết người dùng nào sở hữu nội dung này)
        public User User { get; set; } // Điều hướng từ Content tới User
    }
}
