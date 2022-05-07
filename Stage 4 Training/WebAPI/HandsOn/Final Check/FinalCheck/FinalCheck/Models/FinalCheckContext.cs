using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FinalCheck.Models
{
    public class FinalCheckContext : DbContext
    {
        public FinalCheckContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
