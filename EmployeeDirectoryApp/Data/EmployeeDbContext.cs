using EmployeeDirectoryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDirectoryApp.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options): base(options)
        {
        }

       /** protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasNoKey();

        }*/

        public DbSet<Employee> Employees { get; set; }
    }
}
