﻿// <auto-generated />
using EmployeeAttendance.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeAttendance.Infrastructure.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    partial class EmployeeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeAttendance.Domain.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Designation = "Senior Frontend Developer",
                            Name = "Md.Sharafat Ayon"
                        },
                        new
                        {
                            Id = 2,
                            Designation = "Product Acceptance Engineer",
                            Name = "Mejbaur Bahar Fagun"
                        },
                        new
                        {
                            Id = 3,
                            Designation = "Business Analyst",
                            Name = "Ifrat Jahan Chowdhury"
                        },
                        new
                        {
                            Id = 4,
                            Designation = ".NET (Intern)",
                            Name = "Md Sayeedur Rahman"
                        },
                        new
                        {
                            Id = 5,
                            Designation = ".NET(Intern)",
                            Name = "Raisa Rokib"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
