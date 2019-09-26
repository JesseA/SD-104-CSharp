using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_StudentRegistration.Models
{
    public class Student
    {
        public int ID { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Student Name")]
        public string StudentName { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Student ID")]
        public int StudentIDNumber { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Cell Phone Number")]
        public string CellPhoneNumber { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Age")]
        public int StudentAge { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "E-mail Address")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
    }
}
