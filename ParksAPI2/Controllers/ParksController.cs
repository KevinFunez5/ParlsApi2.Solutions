using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksAPI2.Models;
using System.Linq;

namespace ParksAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParksController : ControllerBase
    {
      private readonly ParksAPI2Context _db;
      public ParksController(ParksAPI2Context db)
      {
        _db = db;
      }
      [HttpGet]
      public async Task<ActionResult<IEnumerable<Park>>> Get(string parkname, string size)
      {
        var query = _db.Parks.AsQueryable();
        if (parkname != null)
        {
          query = query.Where(entry => entry.ParkName == parkname);
        }
        if (size != null)
        {
          query = query.Where(entry => entry.Size == size);
        }
        return await query.ToListAsync();
      }
      [HttpPost]
      public async Task<ActionResult<Park>> Post(Park park)
      {
        _db.Parks.Add(park);
        await _db.SaveChangesAsync();
        return CreatedAtAction(nameof(GetPark), new { id = park.ParkId }, park);
      }
      

    }
}