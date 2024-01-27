using Microsoft.EntityFrameworkCore;
using WAD_17191.Domain.Models;

namespace WAD_17191.Infrastructure.AppData
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<FitnessActivity> Activities { get; set; }

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Configure relationships here

			// One-to-Many relationship between Author and Book
			modelBuilder.Entity<User>()
				.HasMany(a => a.Activities)
				.WithOne(b => b.User)
				.HasForeignKey(b => b.UserId);
		}
	}
}
