using Assignment3_DevynSmith_Section3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3_DevynSmith_Section3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Home page view
        public IActionResult Index()
        {
            return View();
        }

        //podcast view
        public IActionResult Podcast()
        {
            return View();
        }

        //addmovies get view
        [HttpGet]
        public IActionResult AddMovies()
        {
            return View();
        }

        //addmovies post view
        [HttpPost]
        public IActionResult AddMovies(AddMoviesResponse movieResponse)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddMovie(movieResponse);
                return View("Confirmation", movieResponse);
            }
            else
            {
                return View();
            }
        }

        //view movies view
        public IActionResult ViewMovies()
        {
            return View(TempStorage.Movies);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
