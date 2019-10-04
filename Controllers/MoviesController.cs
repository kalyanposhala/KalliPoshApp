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
        KalliPoshDbEntities1 _DbContext = new KalliPoshDbEntities1();
        // GET: Movies
        public ActionResult Index()
        {

            var dbModel = _DbContext.Movies.ToList();
            var ViewModel = new RandamMovieViewModel();
            List<KalliPoshApp.Models.Movies> uiMovies = new List<KalliPoshApp.Models.Movies>();
            foreach (var item in dbModel)
            {
                var dbGenre = _DbContext.Genres.Where(x => x.Id == item.GenreId).FirstOrDefault();

                uiMovies.Add(new Models.Movies()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Genre = dbGenre.Genre1,
                    RelaseDate = dbGenre.ReleaseDate,
                    DateAdded = dbGenre.DateAdded,
                    NumberInStock = Convert.ToInt32(dbGenre.NumberInStock)
                });
            }
            //ViewModel.Movie = model;
            return View(uiMovies);
        }

        public ActionResult Detail(int Id)
        {
            KalliPoshApp.Models.Movies uiMovies = new KalliPoshApp.Models.Movies();
            var dbMovie = _DbContext.Movies.Where(x => x.Id == Id).FirstOrDefault();
            if (dbMovie != null)
            {
                var dbGenre = _DbContext.Genres.Where(x => x.Id == dbMovie.GenreId).FirstOrDefault();
                uiMovies.Name = dbMovie.Name;
                uiMovies.Genre = dbGenre.Genre1;
                uiMovies.RelaseDate = dbGenre.ReleaseDate;
                uiMovies.DateAdded = dbGenre.DateAdded;
                uiMovies.NumberInStock = Convert.ToInt32(dbGenre.NumberInStock);
            }
            else
                uiMovies = null;



            return View(uiMovies);
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