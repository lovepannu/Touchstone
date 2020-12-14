using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Touchstone.Data;
using Touchstone.Models;

namespace Touchstone.Pages.Tutors
{
    public class DetailsModel : PageModel
    {
        private readonly Touchstone.Data.TouchstoneContext _context;

        public DetailsModel(Touchstone.Data.TouchstoneContext context)
        {
            _context = context;
        }

        public Tutor Tutor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Tutor = await _context.Tutor.FirstOrDefaultAsync(m => m.tutorID == id);

            if (Tutor == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
