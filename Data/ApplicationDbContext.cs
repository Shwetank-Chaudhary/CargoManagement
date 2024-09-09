using CargoManagement.Models.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CargoManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }


        public DbSet<CargoOrder> CargoOrders { get; set; }

        public DbSet<CargoOrderDetails> CargoOrderDetails { get; set; }

        public DbSet<City> Citys { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Product> Products { get; set; }


    }
}
