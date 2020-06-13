using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrasshopperAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        // GET: api/Grasshoppers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Grasshopper>>> GetGrasshoppers()
        {
            return await _context.Grasshoppers.ToListAsync();
        }

        
    }
}
