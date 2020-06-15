using GrasshopperAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrasshopperAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GrasshoppersController : ControllerBase
    {
        private readonly GrasshopperContext _context;

        public GrasshoppersController(GrasshopperContext context)
        {
            _context = context;
        }

        #region Endpoints

        // GET: api/Grasshoppers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Grasshopper>>> GetGrasshoppers()
        {
            return await _context.Grasshoppers.ToListAsync();
        }

        // GET: api/Grasshoppers/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Grasshopper>> GetGrasshopper(int id)
        {
            Grasshopper grasshopper = await _context.Grasshoppers.FindAsync(id);
            if (grasshopper == null) return NotFound();
            return grasshopper;
        }

        // PUT: api/Grasshoppers/1
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGrasshopper(int id, Grasshopper grasshopper)
        {
            if (id != grasshopper.Id) return BadRequest();
            _context.Entry(grasshopper).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GrasshopperExists(id)) return NotFound();
                else throw;
            }

            return NoContent();
        }

        // POST: api/Grasshoppers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Grasshopper>> PostGrasshopper(Grasshopper grasshopper)
        {
            _context.Grasshoppers.Add(grasshopper);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetGrasshopper), new { id = grasshopper.Id }, grasshopper);
        }

        // DELETE: api/Grasshoppers/1
        [HttpDelete("{id}")]
        public async Task<ActionResult<Grasshopper>> DeleteGrasshopper(int id)
        {
            Grasshopper grasshopper = await _context.Grasshoppers.FindAsync(id);
            if (grasshopper == null) return NotFound();
            _context.Grasshoppers.Remove(grasshopper);
            await _context.SaveChangesAsync();

            return grasshopper;
        }

        #endregion

        #region Private Helpers

        private bool GrasshopperExists(int id)
        {
            return _context.Grasshoppers.Any(e => e.Id == id);
        }

        #endregion
    }
}
