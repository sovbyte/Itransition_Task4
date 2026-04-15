using System.Security.Claims;
using Itransition_Task4.Data;
using Itransition_Task4.Models;
using Microsoft.AspNetCore.Authorization;

namespace Itransition_Task4.Services;

public class ActiveUserHandler(IUserRepository userRepository) : AuthorizationHandler<ActiveUserRequirement>
{
    protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, ActiveUserRequirement requirement)
    {
        var userIdClaim = context.User.FindFirst(ClaimTypes.NameIdentifier);
        if (userIdClaim == null) return;

        var userId = int.Parse(userIdClaim.Value);

        var user = await userRepository.GetByIdAsync(userId);
        
        if (user != null && user.Status != Status.Blocked)
        {
            context.Succeed(requirement);
        }
    }
}