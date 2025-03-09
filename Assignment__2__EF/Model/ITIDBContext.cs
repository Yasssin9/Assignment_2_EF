using Assignment__2__EF.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_EntityFramework.Model
{
    public class ITIDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-G9E4HBT;database=ITIDatabase;trusted_connection=true;trustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            //Table Course
            modelBuilder.Entity<Course>().HasKey(x => x.Id);

            modelBuilder.Entity<Course>().Property(x => x.Duration);

            modelBuilder.Entity<Course>().Property(x=>x.Name);

            modelBuilder.Entity<Course>().Property(x => x.Description);

            modelBuilder.Entity<Course>().Property(x => x.Top_ID);

            //Table Department
            modelBuilder.Entity<Department>().HasKey(x => x.Id);

            modelBuilder.Entity<Department>().Property(x => x.Name);

            modelBuilder.Entity<Department>().Property(x => x.Ins_Id);

            modelBuilder.Entity<Department>().Property(x => x.HiringDate);

            //TableStud_Course

            modelBuilder.Entity<StudentCourse>().HasKey(x => new { x.StudentId, x.CourseId });
            modelBuilder.Entity<StudentCourse>().Property(x => x.Grade);


            //TableCourse_Inst

            modelBuilder.Entity<CourseInstructor>().HasKey(x => new { x.CourseId, x.InstructorId });
            modelBuilder.Entity<CourseInstructor>().Property(x=>x.Evaluate);

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentCourse { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Topic> Topic { get; set; }

        public DbSet<CourseInstructor> CourseInstructor { get; set; }
        public DbSet<Instructor> Instructors { get; set; }


        



    }
}
