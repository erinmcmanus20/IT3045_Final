using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using IT3045_Final.Models;
using Microsoft.Extensions.Logging;
using IT3045_Final.Interfaces;
using IT3045_Final.Data;

namespace It3045_Final.Controllers;

[ApiController]
[Route("[controller]")]

public class BaseballTeamController : Controller
{
    private readonly ILogger<BaseballTeamController> _logger;
    private readonly IBaseballTeamContextDAO _context;

    public BaseballTeamController(ILogger<BaseballTeamController> logger, IBaseballTeamContextDAO context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_context.GetAllTeams());
    }

    [HttpGet("id")]
    public IActionResult GetByID(int? id)
    {
        if (id == null || id == 0)
            return Ok(_context.GetAllTeams());
        
        var team = _context.GetTeamByID((int)id);

        if (team == null)
            return NotFound(id);
        
        return Ok(team);
    }

    [HttpDelete]
    public IActionResult Delete(int? id)
    {
       if (id == null || id == 0)
        return Ok(_context.GetAllTeams());
       var team = _context.GetTeamByID((int)id);

       if (team == null)
            return NotFound((int)id);

        _context.RemoveTeamById((int)id);

        return Ok(team);
    }
    [HttpPut]
    public IActionResult Put(BaseballTeam team)
    {
        var result = _context.UpdateTeam(team);

        if (team == null)
            return NotFound(team);
        
        return Ok(team);
    }
    [HttpPost]
    public IActionResult Post(BaseballTeam team)
    {
        var result = _context.AddTeam(team);

        if (result == null)
            return StatusCode(500, "Team Already Exists");

        return Ok();
    }
}

