using EfusersRz.Model;
using Microsoft.EntityFrameworkCore;

namespace EfuserRz.Data
{
	public class ApplicationDbContext : DbContext
	{
		//Define tables-entities
		public DbSet<User> Users { get; set; }
		public DbSet<Address> Address { get; set; }

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>()
				.HasOne(u => u.Address)
				.WithOne(a => a.User)
				.HasForeignKey<User>(u => u.AddressId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
