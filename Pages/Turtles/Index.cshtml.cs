using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesTurtle7.Data;
using RazorPagesTurtle7.Models;

namespace RazorPagesTurtle7.Pages.Turtles
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesTurtle7.Data.RazorPagesTurtle7Context _context;

        public IndexModel(RazorPagesTurtle7.Data.RazorPagesTurtle7Context context)
        {
            _context = context;
        }

        public IList<Turtle> Turtle { get;set; }

        public async Task OnGetAsync()
        {
            Turtle = await _context.Turtle.ToListAsync();
        }
    }
}
