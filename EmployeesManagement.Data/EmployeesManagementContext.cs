namespace EmployeesManagement.Data
{
    using EmployeesManagement.Models;
    using Microsoft.EntityFrameworkCore;

    public class EmployeesManagementContext : DbContext
    {
        public EmployeesManagementContext(DbContextOptions<EmployeesManagementContext> options)
            : base(options)
        { }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<ExperienceLevelType> ExperienceLevelTypes { get; set; }

        public DbSet<Town> Towns { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasOne(e => e.Company)
                    .WithMany(c => c.Employees)
                    .HasForeignKey(e => e.CompanyId);

                entity.HasOne(e => e.ExperienceLevel)
                    .WithMany(el => el.Employees)
                    .HasForeignKey(e => e.ExperienceLevelId);

                entity.Property(e => e.Salary)
                    .HasColumnType("decimal(10,2)");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasOne(c => c.Town)
                    .WithMany(t => t.Companies)
                    .HasForeignKey(c => c.TownId);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
