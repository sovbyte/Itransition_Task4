using Itransition_Task4.Models;
using Microsoft.EntityFrameworkCore;

namespace Itransition_Task4.Data;

public interface IUserRepository
{
    Task<List<User>> GetAllAsync();
    Task<User?> GetByIdAsync(int id); 
    Task<List<User>> GetUsersByIdsAsync(List<int> ids);
    Task<User?> GetByEmailAsync(string email);
    Task UpdateRangeAsync(List<User> users);
    Task DeleteRangeAsync(List<User> users);
    Task AddAsync(User user);
    
    
}
public class UserRepository(ApplicationContext db) : IUserRepository
{
    public async Task<List<User>> GetAllAsync()
    {
        return await db.Users.ToListAsync();
    }

    public async Task<User?> GetByIdAsync(int id)
    {
        return await db.Users.FindAsync(id);
    }

    public async Task<List<User>> GetUsersByIdsAsync(List<int> ids)
    {
        return await db.Users.Where(u => ids.Contains(u.Id)).ToListAsync();
    }

    public async Task<User?> GetByEmailAsync(string email)
    {
        return  await db.Users.FirstOrDefaultAsync(u => u.Email == email);
    }

    public async Task UpdateRangeAsync(List<User> users)
    {
        db.Users.UpdateRange(users);
        await db.SaveChangesAsync();
    }
    
    public async Task DeleteRangeAsync(List<User> users)
    {
        db.Users.RemoveRange(users);
        await db.SaveChangesAsync();
    }

    public async Task AddAsync(User user)
    {
        db.Users.Add(user);
        await db.SaveChangesAsync();
    }
}