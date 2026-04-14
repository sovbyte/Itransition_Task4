using Microsoft.EntityFrameworkCore;
using Itransition_Task4.Models;
using Itransition_Task4.Services;

namespace Itransition_Task4;

public class ApplicationContext(DbContextOptions<ApplicationContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; } = null!;

    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                Name = "Admin",
                Email = "admin@example.com",
                HashedPassword = PasswordHasher.HashPassword("a"),
                LastLoginTime = DateTime.UtcNow,
                Statuses = Status.Active
            },
            new User
            {
                Id = 2,
                Name = "John Doe",
                Email = "john@example.com",
                HashedPassword = PasswordHasher.HashPassword("a"),
                LastLoginTime = DateTime.UtcNow.AddDays(-1),
                Statuses = Status.Active
            },
            new User
            {
                Id = 3,
                Name = "Jane Smith",
                Email = "jane@example.com",
                HashedPassword = PasswordHasher.HashPassword("a"),
                LastLoginTime = DateTime.UtcNow.AddHours(-5),
                Statuses = Status.Active
            },
            new User
            {
                Id = 4,
                Name = "Ivan Ivanov",
                Email = "ivan@example.com",
                HashedPassword = PasswordHasher.HashPassword("a"),
                LastLoginTime = DateTime.UtcNow.AddDays(-3),
                Statuses = Status.Active
            });
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasIndex(e => e.Email).IsUnique();
        });
    }
}