using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdentityApp.Authorization
{
    public class OnlyBloggerAuthorization : AuthorizationHandler<OnlyBloggerAuthorization>, IAuthorizationRequirement
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, OnlyBloggerAuthorization requirement)
        {
            if(context.User.IsInRole("Blogger"))
            {
                context.Succeed(requirement);
            }
            else
            {
                context.Fail();
            }
            return Task.CompletedTask;
        }
    }
}
