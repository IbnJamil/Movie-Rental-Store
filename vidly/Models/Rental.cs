using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vidly.Models
{
    public class Rental
    {
        public int Id { get; set; }
        [Required]
        public Customers customers { get; set; }
        [Required]
        public Movies movies { get; set; }
        public DateTime DateRented { get; set; }
        public DateTime? DateReturned { get; set; }
    }
}