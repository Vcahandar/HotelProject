using HotelPorject.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPorject.DataAccessLayer.Concrete
{
	public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-1HLMAF8;Database=ApiDbHotel;Trusted_Connection=True;TrustServerCertificate=True");

		}

		public DbSet<Room> Rooms { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }

    }
}
