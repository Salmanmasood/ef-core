using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfCore.CodeFirst.Models
{
    public class CompanyContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Country> Countries { get; set; }

        public DbSet<Vehicle> Vehicle{ get; set; }
        public CompanyContext(DbContextOptions<CompanyContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // RelationShip Configuration

            modelBuilder.Entity<Employee>().HasOne(x => x.Vehicle).WithOne(x => x.Employee).
                HasForeignKey<Employee>(x => x.VehicleId);

            //Property Configuration 
            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.Property(x => x.VId).HasColumnName("Id");

                entity.Property(x => x.Name).HasColumnName("VehicleName");

            });


            //Entity Configuration......

            modelBuilder.Entity<Vehicle>().HasKey(x => x.VId);


            modelBuilder.Entity<EmployeeRole>().HasKey(t => new { t.EmployeeId, t.RoleId }); //composite Primary key.

            modelBuilder.Entity<EmployeeRole>()
            .HasOne(t => t.Employee)
            .WithMany(t => t.EmployeeRole)
            .HasForeignKey(t => t.EmployeeId);

         modelBuilder.Entity<EmployeeRole>()
       .HasOne(t => t.Role)
       .WithMany(t => t.EmployeeRole)
       .HasForeignKey(t => t.RoleId);


        }


    }
}
