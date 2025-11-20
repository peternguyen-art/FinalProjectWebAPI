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
    }
}
