using Itransition_Task4.Models;
using Microsoft.EntityFrameworkCore;

namespace Itransition_Task4.Data;

public interface IUserRepository
{
    Task<List<User>> GetAllAsync();
    Task<List<User>> GetUsersByIdsAsync(List<int> ids);
    Task UpdateRangeAsync(List<User> users);
    Task DeleteRangeAsync(List<User> users);
}
public class UserRepository(ApplicationContext db) : IUserRepository
{
    public async Task<List<User>> GetAllAsync()
    {
        return await db.Users.ToListAsync();
    }
    
    public async Task<List<User>> GetUsersByIdsAsync(List<int> ids)
    {
        return await db.Users.Where(u => ids.Contains(u.Id)).ToListAsync();
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
}