using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using vidly.Dtos;
using vidly.Models;

namespace vidly.Controllers.Api
{
    public class NewRentalController : ApiController
    {
        ApplicationDbContext _context;
        public NewRentalController()
        {
            _context = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult NewRental(NewRentalDto newRental)
        {
            var customer = _context.Customers.Single(x => x.Id == newRental.CustomerId);
            var movieList = _context.Movies.Where(x => newRental.MovieId.Contains(x.Id)).ToList();
            foreach (var movie in movieList)
            {
                if (movie.Aviliability == 0)
                    return BadRequest("Movie is Not Currently Avialible");
                movie.Aviliability--;
                var rental = new Rental()
                {
                    customers = customer,
                    movies = movie,
                    DateRented = DateTime.Now
                };
                _context.Rental.Add(rental);
                
            }
            _context.SaveChanges();
            return Ok();
        }
    }
}
