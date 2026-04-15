using Itransition_Task4.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Itransition_Task4.Controllers;

[Controller]
[Authorize]
public class UsersController(ApplicationContext db) : Controller
{
    [HttpGet]
    public ActionResult GetUsers()
    {
        var usersViewModels = db.Users.Select(user => new UserViewModel
        {
            Id = user.Id,
            Name = user.Name,
            Email = user.Email,
            LastLoginTime = user.LastLoginTime,
            Status = user.Status.ToString(),
        }).ToList();
        
        return Ok(usersViewModels);
    }

    [HttpPost]
    public ActionResult BlockUsers([FromBody] List<int> ids)
    {
        if (ids == null || ids.Count == 0)
            return BadRequest("No user IDs provided");
        
        
        var usersToBlock = db.Users.Where(u =>  ids.Contains(u.Id)).ToList();

        foreach (var user in usersToBlock)
        {
            user.Status = Status.Blocked;
        }
        
        db.SaveChanges();
        
        return Ok(new {message = $"Successfully blocked {usersToBlock.Count} users"});
    }
    
    [HttpPost]
    public ActionResult UnblockUsers([FromBody] List<int> ids)
    {
        if (ids == null || ids.Count == 0)
            return BadRequest("No user IDs provided");
        
        var usersToUnblock = db.Users.Where(u =>  ids.Contains(u.Id)).ToList();

        foreach (var user in usersToUnblock)
        {
            if(user.Status == Status.Blocked)
            {
                user.Status = Status.Active;
            }
        }
        
        db.SaveChanges();
        
        return Ok(new {message = $"Successfully unblocked {usersToUnblock.Count} users"});
    }    
    
    [HttpPost]
    public ActionResult DeleteUsers([FromBody] List<int> ids)
    {
        if (ids == null || ids.Count == 0)
            return BadRequest("No user IDs provided");
        
        var usersToDelete = db.Users.Where(u =>  ids.Contains(u.Id)).ToList();
        
        db.Users.RemoveRange(usersToDelete);
        
        db.SaveChanges();
        
        return Ok(new {message = $"Successfully deleted {usersToDelete.Count} users"});
    }
}