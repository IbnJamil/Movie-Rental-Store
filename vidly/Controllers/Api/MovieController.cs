using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using vidly.Dtos;
using vidly.Models;
using System.Data.Entity;

namespace vidly.Controllers.Api
{
    public class MovieController : ApiController
    {
        ApplicationDbContext _context;
        public MovieController()
        {
            _context = new ApplicationDbContext();
        }
        [HttpGet]
        public IEnumerable<MovieDto> ListMovie(string queries = null)
        {
            var movieQuery = _context.Movies.Include(x => x.Genre).Where(c=>c.Aviliability>0);
            if (!string.IsNullOrWhiteSpace(queries))
                movieQuery = movieQuery.Where(x => x.MoviesName.Contains(queries));

            var movies= movieQuery.ToList().Select(Mapper.Map<Movies, MovieDto>);
            return movies;
        }
        [HttpGet]
        public MovieDto Details(int id)
        {
            var movie = _context.Movies.Include(x=>x.Genre).SingleOrDefault(x => x.Id == id);
            if (movie == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            var moviedto = Mapper.Map<Movies, MovieDto>(movie);
            return moviedto;
        }
        [HttpPost]
        public IHttpActionResult CreateMovie(MovieDto moviedto)
        {
            if (!ModelState.IsValid)
                BadRequest();
            var movie = new Movies();
            var MapMovie = Mapper.Map<MovieDto, Movies>(moviedto);
            _context.Movies.Add(MapMovie);
            _context.SaveChanges();
            moviedto.Id = MapMovie.Id;
            return Created(new Uri(Request.RequestUri + "/" + moviedto.Id), moviedto);
        }
        [HttpPut]
        public IHttpActionResult UpdateMovie(MovieDto moviedto,int id)
        {
            if (!ModelState.IsValid)
                BadRequest();
            var movie = _context.Movies.SingleOrDefault(x => x.Id == id);
            if (movie == null)
                NotFound();
            var MapMovie = Mapper.Map(moviedto,movie);
            _context.SaveChanges();
            moviedto.Id = MapMovie.Id;
            return Created(new Uri(Request.RequestUri + "/" + moviedto.Id), moviedto);

        }
        [HttpDelete]
        public void DeleteMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(x => x.Id == id);
            if (movie == null)
                NotFound();
            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }
    }
}