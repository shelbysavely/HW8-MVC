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
    public class MoviesController : Controller
    {
        private readonly DB_128040_practiceContext _context;

        public MoviesController(DB_128040_practiceContext context)
        {
            _context = context;
        }

        // GET: Movies
        public async Task<IActionResult> Index()
        {
            var dB_128040_practiceContext = _context.Movies.Include(m => m.Director);
            return View(await dB_128040_practiceContext.ToListAsync());
        }

        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Movies == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies
                .Include(m => m.Director)
                .FirstOrDefaultAsync(m => m.MovieId == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        


        
                  

        

        private bool MovieExists(int id)
        {
          return (_context.Movies?.Any(e => e.MovieId == id)).GetValueOrDefault();
        }
    }
}
