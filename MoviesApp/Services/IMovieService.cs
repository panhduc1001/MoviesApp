using System;
using MoviesApp.Models;

namespace MoviesApp.Services
{
    public interface IMovieService
    {
        List<Movie> GetAll();

        Movie GetById(int id);

        void Add(Movie movice);
    }
}

