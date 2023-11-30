using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using IT3045_Final.Models;
using Microsoft.Extensions.Logging;
using IT3045_Final.Interfaces;
using IT3045_Final.Data;


namespace IT3045_Final.Controllers;

[ApiController]
[Route("[controller]")]
public class TeamMemberController : Controller
{
    private readonly ILogger<TeamMemberController> _logger;
    private readonly ITeamMemberContextDAO _context;

    public TeamMemberController(ILogger<TeamMemberController> logger, ITeamMemberContextDAO context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_context.GetAllMembers());

    }

    //[HttpGet("id")]

    // public IActionResult GetById(int id)
    // {
    //     var member = _context.GetMemberbyId(id);
    //     if (member == null)
    //         return NotFound(id);
        
    //     return Ok(member);
    // }

}
