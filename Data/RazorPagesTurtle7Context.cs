using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesTurtle7.Data
{
    public class RazorPagesTurtle7Context : DbContext
    {
        public RazorPagesTurtle7Context(
            DbContextOptions<RazorPagesTurtle7Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesTurtle7.Models.Turtle> Turtle { get; set; }
    }
}
