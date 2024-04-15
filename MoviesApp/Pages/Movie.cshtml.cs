using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoviesApp.Context;
using MoviesApp.Models;
using MoviesApp.Services;

namespace MoviesApp.Pages
{
    public class MovieModel : PageModel
    {
        private IMovieService _service { get; set; }

        public Movie Movie { get; set; }

        public MovieModel(IMovieService service)
        {
            _service = service;
        }

        public void OnGet(int id)
        {
            Movie = _service.GetById(id);
        }
    }
}
