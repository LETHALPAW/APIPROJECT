using APIProjectCamp.Entities;
using Microsoft.EntityFrameworkCore;

namespace APIProjectCamp.Context
{
	public class ApiContext:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=GE-ABALLI15\\MSSQLSERVER2022;database=ApiYummyDb;user id=sa;password=Btnsft1958;TrustServerCertificate=True;");
		}
		public DbSet<Category> Categories { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Image> Images { get; set; }
		public DbSet<Chef> Chefs { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Message> Messages { get; set; }
		public DbSet<Service> Services { get; set; }
		public DbSet<Testimonial> Testimonials { get; set; }
		public DbSet<Feature> Features { get; set; }
	}
}
