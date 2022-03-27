using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;
using vidly.ViewModels;

namespace vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        ApplicationDbContext _Context;
        public MoviesController()
        {
            _Context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _Context.Dispose();
        }
        public ActionResult Index()
        {
            if (User.IsInRole(RoleName.CanMangeMovie))
                return View("Index");
            return View("ReadOnlyList");
        }
        [Authorize(Roles = RoleName.CanMangeMovie)]
        public ActionResult AddMovie()
        {
            var movie = new ViewModelMovie();
            movie.Genre = _Context.Genre.ToList();
            return View(movie);
        }
        [HttpPost]
        [Authorize(Roles =RoleName.CanMangeMovie)]
        public ActionResult PostMovie(ViewModelMovie movie)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("AddMovie");
            var movieEntry = new Movies();
            movieEntry.DateAdded = DateTime.Now.Date;
            movieEntry.GenreId = movie.GenreId;
            movieEntry.MoviesName = movie.MoviesName;
            movieEntry.NumberInStock = (int)movie.NumberInStock;
            movieEntry.Aviliability = movie.Avialibilty;
            _Context.Movies.Add(movieEntry);
            _Context.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize(Roles = RoleName.CanMangeMovie)]
        public ActionResult Details(int id)
        {
            var movie = new Movies();
            movie.Genre = new Genre();
            movie = _Context.Movies.SingleOrDefault(x => x.Id == id);
            movie.Genre = _Context.Genre.SingleOrDefault(x => x.Id == movie.GenreId);
            return View(movie);
        }
    }
    
}