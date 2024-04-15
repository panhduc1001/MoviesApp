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
    public class AddMovieModel : PageModel
    {
        //[BindProperty]
        //public string Title { get; set; }
        //[BindProperty]
        //public int Rate { get; set; }
        //[BindProperty]
        //public string Description { get; set; }

        [BindProperty]
        public Movie? Movie { get; set; }

        private IMovieService _service { get; set; }

        public AddMovieModel(IMovieService service)
        {
            _service = service;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            var value = $"{Movie?.Title} - {Movie?.Rate} - {Movie?.Description}";
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _service.Add(Movie);

            return Redirect("/Movies");
        }
    }
}
