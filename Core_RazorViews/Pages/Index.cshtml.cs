#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Core_RazorViews.Models;

namespace Core_RazorViews.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Core_RazorViews.Models.ApiDbContext _context;

        public IndexModel(Core_RazorViews.Models.ApiDbContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Categories.ToListAsync();
        }
    }
}
