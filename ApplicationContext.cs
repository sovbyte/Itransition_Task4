using Microsoft.EntityFrameworkCore;
using Itransition_Task4.Models;

namespace Itransition_Task4;

public class ApplicationContext(DbContextOptions<ApplicationContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; } = null!;

    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasIndex(e => e.Email).IsUnique();
        });
        modelBuilder.Entity<User>().HasData(
            new User 
            { 
                Id = 1, 
                Name = "Admin", 
                Email = "admin@example.com", 
                HashedPassword = "a",
                LastLoginTime = DateTime.UtcNow, 
                Statuses = Status.Active 
            },
            new User 
            { 
                Id = 2, 
                Name = "John Doe", 
                Email = "john@example.com", 
                HashedPassword = "b",
                LastLoginTime = DateTime.UtcNow.AddDays(-1), 
                Statuses = Status.Unverified 
            },
            new User 
            { 
                Id = 3, 
                Name = "Jane Smith", 
                Email = "jane@example.com", 
                HashedPassword = "c",
                LastLoginTime = DateTime.UtcNow.AddHours(-5), 
                Statuses = Status.Blocked 
            },
            new User 
            { 
                Id = 4, 
                Name = "Ivan Ivanov", 
                Email = "ivan@example.com", 
                HashedPassword = "d",
                LastLoginTime = DateTime.UtcNow, 
                Statuses = Status.Active 
            }
        );
    }
}