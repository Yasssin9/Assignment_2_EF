using Assignment__2__EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_EntityFramework.Model
{
    public class Instructor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Bouns { get; set; }
        public string? Salary { get; set; }
        public string? Address { get; set; }
        public decimal HourRate { get; set; }
        public int Dept_Id { get; set; }

        public Department DepartmentWorking { get; set; }

        public int DepartmentId { get; set; }

        public ICollection<CourseInstructor> CourseInstructor { get; set; }
    }
}
