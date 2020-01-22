using Docker_Wpf_Web_Application.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Docker_Wpf_Web_Application.Data
{
    public class CarBookDataContext : DbContext
    {
        public CarBookDataContext(DbContextOptions<CarBookDataContext> options)
            : base (options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
               .HasMany(c => c.Books)
               .WithOne(r => r.Car);
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Car)
                .WithMany(c => c.Books);
        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Book> Books { get; set; }
    }
}
