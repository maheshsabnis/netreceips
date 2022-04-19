#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Core_RazorViews.Models;

namespace Core_RazorViews.Pages
{
    public class CreateModel : PageModel
    {
        private readonly Core_RazorViews.Models.ApiDbContext _context;

        public CreateModel(Core_RazorViews.Models.ApiDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Categories.Add(Category);
            await _context.SaveChangesAsync();
            // REdirecting to the Index RAzor View 
            return RedirectToPage("./Index");
        }
    }
}
