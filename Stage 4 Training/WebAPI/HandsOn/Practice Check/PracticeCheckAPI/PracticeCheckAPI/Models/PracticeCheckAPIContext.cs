using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PracticeCheckAPI.Models
{
    public class PracticeCheckAPIContext : DbContext
    {
        public PracticeCheckAPIContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
