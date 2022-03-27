using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vidly.Models
{
    public class Movies
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string MoviesName { get; set; }
        public Genre Genre { get; set; }
        [Display(Name = "Genre")]
        [Required]
        public movieEnum GenreId { get; set; }
        [Required]
        [Display(Name = "Uploaded Date")]
        public DateTime DateAdded { get; set; }
        [Required]
        [Display(Name = "Number In Stock")]
        public int NumberInStock { get; set; }
        
        public int Aviliability { get; set; }
    }
    public enum movieEnum
    {
        Drama = 1,
        Comedy = 2,
        Action = 3,
        Thriller = 4,
        Romance = 5,
        Entertainment = 6,
        Season = 7,
        Series = 8
    }
}