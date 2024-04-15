using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoviesApp.Models;
using MoviesApp.Context;
using MoviesApp.Services;

namespace MoviesApp.Pages
{
    public class MoviesModel : PageModel
    {
        public List<Movie> Movies { get; set; }

        private IMovieService _service { get; set; }

        public MoviesModel(IMovieService service)
        {
            _service = service;
        }

        public void OnGet()
        {
            Movies = _service.GetAll();
        }
    }
}
