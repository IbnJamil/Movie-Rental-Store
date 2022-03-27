using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vidly.Models
{
    public class Genre
    {
        public movieEnum Id { get; set; }
        [MaxLength(255)]
        public String GenreName { get; set; }
    }
}