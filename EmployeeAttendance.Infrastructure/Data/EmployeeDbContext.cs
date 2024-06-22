using EmployeeAttendance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttendance.Infrastructure.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "Md.Sharafat Ayon", Designation = "Senior Frontend Developer" },
                new Employee { Id = 2, Name = "Mejbaur Bahar Fagun", Designation = "Product Acceptance Engineer" },
                new Employee { Id = 3, Name = "Ifrat Jahan Chowdhury", Designation = "Business Analyst" },
                new Employee { Id = 4, Name = "Md Sayeedur Rahman", Designation = ".NET (Intern)" },
                new Employee { Id = 5, Name = "Raisa Rokib", Designation = ".NET(Intern)" }
                );
        }

    }
}
