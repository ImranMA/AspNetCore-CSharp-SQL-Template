using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Template.Models
{
    public class Student
    {
        [Key]
        public string StudentId { get; set; }

        public string Name { get; set; }        
    }
}
