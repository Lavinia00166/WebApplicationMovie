using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationMovie.Models;

namespace WebApplicationMovie.Data
{
    public class WebApplicationMovieContext : DbContext
    {
        public WebApplicationMovieContext (DbContextOptions<WebApplicationMovieContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationMovie.Models.Movie> Movie { get; set; }
    }
}
