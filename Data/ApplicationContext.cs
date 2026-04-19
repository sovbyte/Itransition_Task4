using Itransition_Task4.Models;
using Itransition_Task4.Services;
using Microsoft.EntityFrameworkCore;

namespace Itransition_Task4.Data;

public class ApplicationContext(DbContextOptions<ApplicationContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; } = null!;
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(DataSeeder.GetPredefinedUsers());
        
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasIndex(e => e.Email).IsUnique();
        });
    }
}
