using BrainStormEra.Models;
using Microsoft.EntityFrameworkCore;
namespace BrainStormEra.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) 
            : base(options)
        {
            
        }
        // Define your DbSet properties here to map to tables
        public DbSet<UserAccount> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Certificate> Certificate { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<CourseCategory> courseCategories { get; set; }
        public DbSet<CourseCategoryMapping> courseCategoriesMapping { get; set; }

        // You can optionally override OnConfiguring if needed
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Use SQL Server by default, though this can be configured in Startup.cs or appsettings.json
                optionsBuilder.UseSqlServer("Your-Default-Connection-String");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseCategoryMapping>().HasNoKey();

            // Other configurations...
        }
    }
}
