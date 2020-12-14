using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Touchstone.Data;
using Touchstone.Models;

namespace Touchstone.Pages.Batches
{
    public class DeleteModel : PageModel
    {
        private readonly Touchstone.Data.TouchstoneContext _context;

        public DeleteModel(Touchstone.Data.TouchstoneContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Batch Batch { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Batch = await _context.Batch.FirstOrDefaultAsync(m => m.batchID == id);

            if (Batch == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Batch = await _context.Batch.FindAsync(id);

            if (Batch != null)
            {
                _context.Batch.Remove(Batch);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
