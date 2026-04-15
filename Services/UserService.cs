using Itransition_Task4.Data;
using Itransition_Task4.Models;

namespace Itransition_Task4.Services;

public interface IUserService
{
    Task<List<UserViewModel>> GetUsersListAsync();
    Task BlockUsersAsync(List<int> ids);
    Task UnblockUsersAsync(List<int> ids);

    Task DeleteUsersAsync(List<int> ids);
    
    Task<bool> ConfirmEmailAsync(int userId);
    Task<bool> ResetPasswordAsync(string email, string newPassword);
}

public class UserService(IUserRepository userRepository) : IUserService
{
    public async Task<List<UserViewModel>> GetUsersListAsync()
    {
        var users = await userRepository.GetAllAsync();
        return users.Select(user => new UserViewModel
        {
            Id = user.Id,
            Name = user.Name,
            Email = user.Email,
            LastLoginTime = user.LastLoginTime,
            Status = user.Status.ToString()
        }).ToList();
    }

    public async Task BlockUsersAsync(List<int> ids)
    {
        var users = await userRepository.GetUsersByIdsAsync(ids);
        foreach (var user in users)
        {
            user.Status = Status.Blocked;
        }
        await userRepository.UpdateRangeAsync(users);
    }
    
    public async Task UnblockUsersAsync(List<int> ids)
    {
        var users = await userRepository.GetUsersByIdsAsync(ids);
        foreach (var user in users)
        {
            user.Status = Status.Active;
        }
        await userRepository.UpdateRangeAsync(users);
    }
    
    public async Task DeleteUsersAsync(List<int> ids)
    {
        var users = await userRepository.GetUsersByIdsAsync(ids);
        await userRepository.DeleteRangeAsync(users);
    }

    public async Task<bool> ConfirmEmailAsync(int userId)
    {
        var user = await userRepository.GetByIdAsync(userId);
        if (user == null) return false;

        user.Status = Status.Active;
        await userRepository.UpdateRangeAsync([user]);
        return true;
    }

    public async Task<bool> ResetPasswordAsync(string email, string newPassword)
    {
        var allUsers = await userRepository.GetAllAsync();
        var user = allUsers.FirstOrDefault(u => u.Email == email);
        if (user == null) return false;

        user.HashedPassword = PasswordHasher.HashPassword(newPassword);
        await userRepository.UpdateRangeAsync([user]);
        return true;
    }
}