using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    class NorthwindContext : DbContext
    {
        private override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=Northwind; Trusted_Connection=true");
        }
        public DbSet<Car> Products { get; set; }
        public DbSet<Brand> Categories { get; set; }
        public DbSet<Color> Customers { get; set; }
    }
}
