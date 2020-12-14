using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Touchstone.Models
{
    public class Branch
    {
        [Key]
        public int branchID { get; set; }
        public string branchName { get; set; }
        public string branchAddress { get; set; }
    }
}
