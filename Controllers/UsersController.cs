using Itransition_Task4.Data;
using Itransition_Task4.Models;
using Itransition_Task4.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Itransition_Task4.Controllers;

[Controller]
[Authorize(Policy = "ActiveUser")]
public class UsersController(IUserService userService) : Controller
{
    public IActionResult Index() => View();
    
    [HttpGet]
    public async Task<JsonResult> GetUsers()
    {
        var users = await userService.GetUsersListAsync();
        return Json(users);
    }

    [HttpPost]
    public async Task<IActionResult> Block([FromBody] List<int> ids)
    {
        if (ids == null || !ids.Any()) 
        {
            return Json(new { success = false, message = "No users selected" });
        }
        
        await userService.BlockUsersAsync(ids);
        return Json(new { success = true });
    }
    
    
    [HttpPost]
    public async Task<IActionResult> Unblock([FromBody] List<int> ids)
    {
        if (ids == null || !ids.Any()) 
        {
            return Json(new { success = false, message = "No users selected" });
        }
        
        await userService.UnblockUsersAsync(ids);
        return Json(new { success = true });
    }
    
    [HttpPost]
    public async Task<IActionResult> Delete([FromBody] List<int> ids)
    {
        if (ids == null || !ids.Any()) 
        {
            return Json(new { success = false, message = "No users selected" });
        }
        
        await userService.DeleteUsersAsync(ids);
        return Json(new { success = true });
    }
}