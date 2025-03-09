using Assignment__2__EF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_EntityFramework.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public string? Address { get; set; }
        [Range(22, 60)]
        public int Age { get; set; }
        public int Dep_Id { get; set; }

        public Department Department { get; set; }

        
        public int DepartmentId { get; set; }

        public ICollection<StudentCourse> StudentCourse { get; set; }
    }
}
