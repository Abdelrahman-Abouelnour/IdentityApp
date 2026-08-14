using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdentityApp.Controllers
{
    [Authorize]
    public class AccessController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Pokemon")]
        public IActionResult PokemonAccess()
        {
            return View();
        }
        [Authorize(Policy = "OnlyBloggerChecker")]
        public IActionResult OnlyBloggerChecker()
        { 
            return View();
        }
        [Authorize(Policy = "CheckNicknameTeddy")]
        public IActionResult CheckNicknameTeddy()
        {
            return View();
        }
    }
}
