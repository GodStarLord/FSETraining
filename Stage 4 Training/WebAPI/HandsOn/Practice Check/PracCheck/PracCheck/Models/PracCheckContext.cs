using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PracCheck.Models
{
    public class PracCheckContext : DbContext
    {
        public PracCheckContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
