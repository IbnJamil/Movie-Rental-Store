using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vidly.Models;

namespace vidly.Dtos
{
    public class GenreDto
    {

        public movieEnum Id { get; set; }
       
        public String GenreName { get; set; }
    }
}