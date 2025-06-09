using kolokwium1.DTO;
using kolokwium1.Services;
using Microsoft.AspNetCore.Mvc;

namespace kolokwium1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SomeController(AppDbContext db) : Controller
{
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] SomeDTO data)
    {
        if(data == null)
            return BadRequest();
        
        db.SaveChanges();
        return Created();
    }
}