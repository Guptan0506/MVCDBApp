using Microsoft.EntityFrameworkCore;
using MvcDBApp.Models;
using MVCDBApp.Models;

public class MVCDBAppContext(DbContextOptions<MVCDBAppContext> options) : DbContext(options)
{
    public DbSet<MVCDBApp.Models.Student> Student { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Student>().HasData(
            new Student { Id = 1, Name = "John Doe", City = "New York", Age = 20 },
            new Student { Id = 2, Name = "Jane Smith", City = "Los Angeles", Age = 22 },
            new Student { Id = 3, Name = "Bob Johnson", City = "Chicago", Age = 25 }
          );
        modelBuilder.Entity<Course>().HasData(
            new Course { courseId = 1, courseName = "Math", courseDescription = "Algebra and calculus" },
            new Course { courseId = 2, courseName = "Science", courseDescription = "Biology and chemistry" },
            new Course { courseId = 3, courseName = "History", courseDescription = "World history" }
          );
    }
}
