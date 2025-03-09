using Assignment__2__EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_EntityFramework.Model
{
    public class Course
    {
        public int Id { get; set; }
        public string Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Top_ID { get; set; }

        public int TopicId { get; set; }

        public Topic Topic { get; set; }

        public ICollection<StudentCourse> StudentCourse { get; set; }

        public ICollection<CourseInstructor> CourseInstructor { get; set; }

    }
}
