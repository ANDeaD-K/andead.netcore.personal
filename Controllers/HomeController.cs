using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Route("/")]
public class HomeController : Controller
{
    [HttpGet("personal")]
    public IActionResult GetPersonal()
    {
        return Ok($"This is GetPersonal");
    }

    [Authorize, HttpGet("personal2")]
    public IActionResult GetPersonal2()
    {
        return Ok($"This is GetPersonal2");
    }
}