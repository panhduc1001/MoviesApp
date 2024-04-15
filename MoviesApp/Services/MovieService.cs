using System;
using MoviesApp.Context;
using MoviesApp.Models;

namespace MoviesApp.Services
{
    public class MovieService : IMovieService
    {
        private ApplicationDbContext _context { get; set; }

        public MovieService(ApplicationDbContext context) 
        {
            _context = context;
        }

        public void Add(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public List<Movie> GetAll() => _context.Movies.ToList();

        public Movie GetById(int id) => _context.Movies.FirstOrDefault(n => n.Id == id);
    }
}

