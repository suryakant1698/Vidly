using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using System.Data.Entity;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    public class MoviesController : Controller
    {

        public ApplicationDbContext  context { get; set; }
        public MoviesController()
        {
            context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            context.Dispose();
        }
        // GET: Movies
        public ActionResult Index()
        {
            var movies = context.Movies.Include(c => c.Genre).ToList();
            return View(movies);
        }
    }
}