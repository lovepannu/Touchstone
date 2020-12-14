using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Touchstone.Models;

namespace Touchstone.Data
{
    public class TouchstoneContext : DbContext
    {
        public TouchstoneContext (DbContextOptions<TouchstoneContext> options)
            : base(options)
        {
        }

        public DbSet<Touchstone.Models.Branch> Branch { get; set; }

        public DbSet<Touchstone.Models.Batch> Batch { get; set; }

        public DbSet<Touchstone.Models.Tutor> Tutor { get; set; }

        public DbSet<Touchstone.Models.Student> Student { get; set; }
    }
}
