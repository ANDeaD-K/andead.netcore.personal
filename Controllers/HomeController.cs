using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Route("/")]
public class HomeController : Controller
{
    [HttpGet("personal")]
    public IActionResult GetPersonal()
    {
        ClaimsIdentity identity = HttpContext.User.Identity as ClaimsIdentity;
        string nameIdentifier = identity.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).Select(c => c.Value).SingleOrDefault();

        return Ok($"This is GetPersonal: ({nameIdentifier}) {User.Identity.Name}");
    }

    [Authorize, HttpGet("personal2")]
    public IActionResult GetPersonal2()
    {
        return Ok($"This is GetPersonal2");
    }
}