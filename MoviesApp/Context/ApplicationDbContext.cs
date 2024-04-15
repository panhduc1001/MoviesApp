using System;
using Microsoft.EntityFrameworkCore;
using MoviesApp.Models;

namespace MoviesApp.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
    }
}

