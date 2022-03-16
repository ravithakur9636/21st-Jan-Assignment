using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstApproachAssignment.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public String Name { get; set; }
        public String City { get; set; }
        public String Branch { get; set; }
        public int Percentage { get; set; }

    }
}