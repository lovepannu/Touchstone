using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Touchstone.Models
{
    public class Tutor
    {

        [Key]
        public int tutorID { get; set; }
        public string tutorName { get; set; }
        public string tutorEmail { get; set; }
        public int tutorMobile { get; set; }
        public string tutorAddress { get; set; }
        //Foriegn key
        public int branch_ID { get; set; }
        public Branch branch_obj { get; set; }
    }
}
