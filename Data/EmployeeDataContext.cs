using Microsoft.EntityFrameworkCore;
using System.DateTime;

namespace Employees.Data
{
    public class EmployeeDataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public EmployeeDataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Configuration.GetConnectionString("EmployeeDB"));
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Employee>().HasData(
                 new Employee { Id = 1, Timestamp = "2025-08-15 02:54:07.9725814Z", SerializedValue = byte[], ValueType = QueueValueType.Configuration, EsuIndex = 0, QueueIndex = 0},


            );
        }
    }
}
