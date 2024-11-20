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
    public class TopController : Controller
    {
        private readonly DB_128040_practiceContext db = new DB_128040_practiceContext();

        

        // GET: Top
        public ActionResult Movies(int number = 10)
        {
            var movies = db.Movies.Include(m => m.Director).OrderByDescending(m => m.Gross).Take(number);

            return View(movies);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }



       
    }
}
