using Microsoft.EntityFrameworkCore;
using Works.Data.Entities;

namespace Works.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Worklog> Worklogs { get; set; }
        public DbSet<Configuration> Configurations { get; set; }



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}