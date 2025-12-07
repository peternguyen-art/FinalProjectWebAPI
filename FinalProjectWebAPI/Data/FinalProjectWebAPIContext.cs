using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalProjectWebAPI.Models;

namespace FinalProjectWebAPI.Data
{
    public class FinalProjectWebAPIContext : DbContext
    {
        public FinalProjectWebAPIContext (DbContextOptions<FinalProjectWebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<FinalProjectWebAPI.Models.Food> Food { get; set; } = default!;
        public DbSet<FinalProjectWebAPI.Models.Student> Student { get; set; } = default!;
        public DbSet<FinalProjectWebAPI.Models.Movie> Movie { get; set; } = default!;
        public DbSet<FinalProjectWebAPI.Models.Book> Book { get; set; } = default!;
    }
}
