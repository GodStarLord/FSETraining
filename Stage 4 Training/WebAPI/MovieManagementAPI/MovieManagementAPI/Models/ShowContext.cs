using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MovieManagementAPI.Models
{
    public class ShowContext : DbContext
    {
        public ShowContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie()
                {
                    Id = 101,
                    Name = "Standard",
                    Duration = 122.3f,
                    Remarks = "Sci-Fi"
                });
        }
    }
}
