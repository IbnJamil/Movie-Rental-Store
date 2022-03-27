using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using vidly.Models;

namespace vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        public string MoviesName { get; set; }
        public GenreDto GenreDto { get; set; }

        public movieEnum GenreId { get; set; }
        
        public DateTime DateAdded { get; set; }

        public int NumberInStock { get; set; }
        public int Aviliability { get; set; }
    }
}