using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Movies.Models;

namespace Movies2.Data
{
    public class Movies2Context : DbContext
    {
        public Movies2Context (DbContextOptions<Movies2Context> options)
            : base(options)
        {
        }

        public DbSet<Movies.Models.Movie> Movie { get; set; } = default!;
    }
}
