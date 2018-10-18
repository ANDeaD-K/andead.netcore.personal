using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Route("/")]
public class HomeController : Controller
{
    [HttpGet("personal")]
    public IActionResult GetPersonal(int userId, string login)
    {
        return Ok($"This is GetPersonal: ({userId}) {login}");
    }

    [Authorize, HttpGet("personal2")]
    public IActionResult GetPersonal2()
    {
        return Ok($"This is GetPersonal2");
    }
}