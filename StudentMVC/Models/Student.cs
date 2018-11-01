using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMVC.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Display(Name = "Mã số sinh viên")]
        public string RollNumber { get; set; }

        [Display(Name = "Họ tên")]
        public string Name { get; set; }        
    }
}
