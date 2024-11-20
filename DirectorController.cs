using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC10.Models;

namespace MVC10.Controllers
{
    public class DirectorController : Controller
    {
        private readonly DB_128040_practiceContext _context;

        public DirectorController(DB_128040_practiceContext context)
        {
            _context = context;
        }

        // GET: Directors
        public async Task<IActionResult> Index()
        {
              return _context.Directors != null ? 
                          View(await _context.Directors.ToListAsync()) :
                          Problem("Entity set 'DB_128040_practiceContext.Directors'  is null.");
        }

        // GET: Directors/Details/5
        public async Task<IActionResult> Info(int? id)
        {
            if (id == null || _context.Directors == null)
            {
                return NotFound();
            }

            var director = await _context.Directors
                .FirstOrDefaultAsync(m => m.DirectorId == id);
            if (director == null)
            {
                return NotFound();
            }

            return View(director);
        }

       

        
        
            

       

        private bool DirectorExists(int id)
        {
          return (_context.Directors?.Any(e => e.DirectorId == id)).GetValueOrDefault();
        }
    }
}
