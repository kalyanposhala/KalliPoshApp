using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KalliPoshApp.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GenreId { get; set; }
        public string Genre { get; set; }
        public DateTime RelaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public int NumberInStock { get; set; }

    }
}