using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Touchstone.Models
{
    public class Student
    {
        [Key]
        public int studentID { get; set; }
        public string studentName { get; set; }
        public int studentMobile { get; set; }
        public string studentEmail { get; set; }
        public string studentAddress { get; set; }
        //Foriegn key
        //public int branch_ID {get; set; }
        //public Branch branch_obj {get; set; }
        //Foriegn key 
        public int tutor_ID { get; set; }
        public Tutor tutor_obj { get; set; }
    }
}
