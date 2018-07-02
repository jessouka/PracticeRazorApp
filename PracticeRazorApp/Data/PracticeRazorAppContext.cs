using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PracticeRazorApp.Models
{
    public class PracticeRazorAppContext : DbContext
    {
        public PracticeRazorAppContext (DbContextOptions<PracticeRazorAppContext> options)
            : base(options)
        {
        }

        public DbSet<PracticeRazorApp.Models.Movie> Movie { get; set; }
    }
}
