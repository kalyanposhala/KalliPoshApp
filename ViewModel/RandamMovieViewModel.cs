using KalliPoshApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KalliPoshApp.ViewModel
{
    public class RandamMovieViewModel
    {
        public List<Movie> Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}