using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Touchstone.Data;
using Touchstone.Models;

namespace Touchstone.Pages.Branchs
{
    public class DetailsModel : PageModel
    {
        private readonly Touchstone.Data.TouchstoneContext _context;

        public DetailsModel(Touchstone.Data.TouchstoneContext context)
        {
            _context = context;
        }

        public Branch Branch { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Branch = await _context.Branch.FirstOrDefaultAsync(m => m.branchID == id);

            if (Branch == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
