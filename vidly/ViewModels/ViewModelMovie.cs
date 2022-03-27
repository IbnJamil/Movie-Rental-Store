using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using vidly.Models;

namespace vidly.ViewModels
{
    public class ViewModelMovie
    {
        public int? id { get; set; }
        [Required]
        [MaxLength(100)]
        public string MoviesName { get; set; }
        [Display(Name = "Genre")]
        [Required]
        public movieEnum GenreId { get; set; }
        [Required]
        [Display(Name = "Uploaded Date")]
        public DateTime? DateAdded { get; set; }
        [Required]
        [Display(Name = "Number In Stock")]

        [Range(1,2000)]
        public int? NumberInStock { get; set; }

        [Display(Name = "Copies Aviliable")]
        public int Avialibilty { get; set; }
        public IEnumerable<Genre> Genre { get; set; }
    }
}