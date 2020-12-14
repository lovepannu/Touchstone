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
    public class IndexModel : PageModel
    {
        private readonly Touchstone.Data.TouchstoneContext _context;

        public IndexModel(Touchstone.Data.TouchstoneContext context)
        {
            _context = context;
        }

        public IList<Branch> Branch { get;set; }

        public async Task OnGetAsync()
        {
            Branch = await _context.Branch.ToListAsync();
        }
    }
}
