using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdentityApp.Authorization
{
    public class NickNameCheck : IAuthorizationRequirement
    {
        public NickNameCheck(String name)
        {
            Name = name;
        }
        public string Name { get; set; }

    }
}
