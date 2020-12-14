using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Touchstone.Models
{
    public class Batch
    {
        [Key]
        public int batchID { get; set; }
        public string batchName { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string courseCost { get; set; }
        //Foriegn key
        public int branch_ID { get; set; }
        public Branch branch_obj { get; set; }
    }
}
