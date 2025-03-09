using Assignment_2_EntityFramework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__2__EF.Model
{
    public class CourseInstructor
    {
        public int CourseId { get; set; }
        public int InstructorId { get; set; }

        public Course Course { get; set; }
        public Instructor Instructor { get; set; }

        public string Evaluate { get; set; }
    }
}
