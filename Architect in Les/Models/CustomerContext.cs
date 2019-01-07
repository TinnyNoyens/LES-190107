using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Les190107.Models
{
    public class CustomerContext : DbContext

    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        { }

        public DbSet<Customer> Customers { get; set; }

        //creatie van een tabel
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customers");
        }

    }
}
