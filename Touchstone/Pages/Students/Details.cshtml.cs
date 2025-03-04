﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Touchstone.Data;
using Touchstone.Models;

namespace Touchstone.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly Touchstone.Data.TouchstoneContext _context;

        public DetailsModel(Touchstone.Data.TouchstoneContext context)
        {
            _context = context;
        }

        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Student.FirstOrDefaultAsync(m => m.studentID == id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
