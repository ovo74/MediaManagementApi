using Microsoft.EntityFrameworkCore;
using MediaManagementApi.Models;

namespace MediaManagementApi.Data
{
	public class ApplicationDbContext : DbContext
	{
		// Các DbSet cho các bảng dữ liệu của bạn
		public DbSet<User> Users { get; set; }
		public DbSet<Content> Contents { get; set; }

		// Constructor nhận các tùy chọn cấu hình từ Startup
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}

		// Nếu bạn muốn cấu hình thêm các bảng hoặc quan hệ giữa các bảng, bạn có thể làm ở đây
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			// Cấu hình các ràng buộc, quan hệ, v.v. nếu cần
		}
	}
}
