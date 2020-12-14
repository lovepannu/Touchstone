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
    public class IndexModel : PageModel
    {
        private readonly Touchstone.Data.TouchstoneContext _context;

        public IndexModel(Touchstone.Data.TouchstoneContext context)
        {
            _context = context;
        }

        public IList<Batch> Batch { get;set; }

        public async Task OnGetAsync()
        {
            Batch = await _context.Batch.ToListAsync();
        }
    }
}
