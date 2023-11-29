using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using IT3045_Final.Models;
using Microsoft.Extensions.Logging;


namespace IT3045_Final.Controllers;

[ApiController]
[Route("[controller]")]
public class TeamMemberController : Controller
{
    private readonly ILogger<TeamMemberController> _logger;

    public TeamMemberController(ILogger<TeamMemberController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }

}
