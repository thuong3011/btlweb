using Microsoft.EntityFrameworkCore;
using webcuathuong.Models;

namespace webcuathuong.Repository
{
	public class DataContext:DbContext
	{
		public DataContext(DbContextOptions<DataContext>options) : base(options)
		{
		}
		public DbSet<Product> Products{ get; set; }
	}
}
