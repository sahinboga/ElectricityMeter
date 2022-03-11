using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
	public class ElectricityMeterContext:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Electricity_Meter;Trusted_Connection=true");
		}

		public DbSet<Company> Companies { get; set; }
		public DbSet<Meter> Meters { get; set; }
		public DbSet<City> Cities { get; set; }
		public DbSet<District> Districts { get; set; }


	}
}
