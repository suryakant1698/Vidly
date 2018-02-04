using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult NewRandom()
        {
            var movie = new Movies() { Name = "Silence of the lambs" };
            var customers = new List<Customers>
            {
                new Customers {Name="Surya" },
                new Customers {Name="Abhay" }
            };
            var viewModel = new RandomMovieViewModel()
            {
                movie = movie,
            Customers=customers
            };
            return View(viewModel);
        }
    }
}