﻿// <auto-generated />
using System;
using EmployeesManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeesManagement.Data.Migrations
{
    [DbContext(typeof(EmployeesManagementContext))]
    partial class EmployeesManagementContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeesManagement.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Bulstat")
                        .IsRequired()
                        .HasMaxLength(9);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<int>("TownId");

                    b.HasKey("CompanyId");

                    b.HasIndex("TownId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("EmployeesManagement.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<int>("ExperienceLevelId");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(10,2)");

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("VacationDays");

                    b.HasKey("EmployeeId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ExperienceLevelId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EmployeesManagement.Models.ExperienceLevelType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("ExperienceLevelTypes");
                });

            modelBuilder.Entity("EmployeesManagement.Models.Town", b =>
                {
                    b.Property<int>("TownId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.HasKey("TownId");

                    b.ToTable("Towns");
                });

            modelBuilder.Entity("EmployeesManagement.Models.Company", b =>
                {
                    b.HasOne("EmployeesManagement.Models.Town", "Town")
                        .WithMany("Companies")
                        .HasForeignKey("TownId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EmployeesManagement.Models.Employee", b =>
                {
                    b.HasOne("EmployeesManagement.Models.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EmployeesManagement.Models.ExperienceLevelType", "ExperienceLevel")
                        .WithMany("Employees")
                        .HasForeignKey("ExperienceLevelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
