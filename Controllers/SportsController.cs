using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using IT3045_Final.Models;
using Microsoft.Extensions.Logging;
using IT3045_Final.Interfaces;
using IT3045_Final.Data;


namespace IT3045_Final.Controllers;

[ApiController]
[Route("[controller]")]
public class SportsController : Controller
{
    private readonly ILogger<SportsController> _logger;
    private readonly SportsContextDAO _context;

    public SportsController(ILogger<SportsController> logger, SportsContextDAO context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_context.GetAllTeamMembers());

    }

    [HttpGet("id")]

    public IActionResult GetById(int? id)
    {
        if (id == null || id == 0)
            return Ok(_context.GetAllTeamMembers());
        
        var sports = _context.GetTeamMemberById((int)id);

        if (sports == null)
            return NotFound(id);
        
        return Ok(id);
    }

    [HttpDelete]
    public IActionResult Delete(int? id)
    {
        if (id == null || id == 0)
            return Ok(_context.GetAllTeamMembers());
        var sports = _context.GetTeamMemberById((int)id);

        if (sports == null)
            return NotFound((int)id);
        
        _context.RemoveTeamMemberById((int)id); 
        
        return Ok(sports);  
    }

    [HttpPut]
    public IActionResult Put(Sports sports)
    {

        var result = _context.UpdateTeamMember(sports);
        if (result == null)
            return NotFound(sports);

        return Ok(sports);  

        
    }

    [HttpPost]
    public IActionResult Post(Sports sports)
    {
        var result = _context.AddTeamMember(sports);

        if (result == null)
            return StatusCode(500, "TeamMember Already Exists");
        
        return Ok(sports);

    }

}