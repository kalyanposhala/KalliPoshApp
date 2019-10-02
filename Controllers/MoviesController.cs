using KalliPoshApp.Models;
using KalliPoshApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KalliPoshApp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {

            var model = GetMovies();
            var ViewModel = new RandamMovieViewModel();
            ViewModel.Movie = model;
            return View(ViewModel);
        }      

        private List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie{ Name="Kalli", Id=1},
                new Movie { Name="Posh", Id=2}
            };
        }
    }
}