using Assignment.Data.ModelData;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Data
{
	public class ApplicationContext : DbContext
	{
		public ApplicationContext(
			DbContextOptions<ApplicationContext> options) : base(options)
		{

		}
		public DbSet<TableEmployee> TableEmployee { get; set; }
		public DbSet<TableCompany> TableCompany { get; set; }


	}
}