using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Touchstone.Data;
using Touchstone.Models;

namespace Touchstone.Pages.Tutors
{
    public class CreateModel : PageModel
    {
        private readonly Touchstone.Data.TouchstoneContext _context;

        public CreateModel(Touchstone.Data.TouchstoneContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Tutor Tutor { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Tutor.Add(Tutor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
