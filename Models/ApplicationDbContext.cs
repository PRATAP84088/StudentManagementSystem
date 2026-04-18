using Microsoft.EntityFrameworkCore;

namespace StudentManagementSystem.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed some initial data
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1,
                    FirstName = "Pratap",
                    LastName = "Singh",
                    Email = "pratap84088@gmail.com",
                    PhoneNumber = "8777786370",
                    Course = "Computer Science and Engineering",
                    EnrollmentDate = new DateTime(2022, 1, 1)
                },
                new Student
                {
                    Id = 2,
                    FirstName = "Riya",
                    LastName = "Sharma",
                    Email = "riya.sharma@example.com",
                    PhoneNumber = "9876543210",
                    Course = "Information Technology",
                    EnrollmentDate = new DateTime(2023, 6, 15)
                }
            );
        }
    }
}
