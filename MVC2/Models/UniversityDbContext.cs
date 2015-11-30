using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC2.Models
{
    public class UniversityDbContext:DbContext
    {
       // public DbSet<Department> Departments { set; get;}
        //public DbSet<Student> Students { set; get; }
        public System.Data.Entity.DbSet<MVC2.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<MVC2.Models.Department> Departments { get; set; }

        public System.Data.Entity.DbSet<MVC2.Models.Teacher> Teachers { get; set; }
        public DbSet<Designation> Designations { get; set; }//same thing as above !!
        public DbSet<Course> Courses { get; set; }

        public System.Data.Entity.DbSet<MVC2.Models.Semester> Semesters { get; set; }
        
        
       // public DbSet<CourseAssignToTeacher> CourseAssignToTeachers { get; set; }
    }
}