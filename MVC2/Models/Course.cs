using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using  System.ComponentModel.DataAnnotations;

namespace MVC2.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        [Required]
        public String Code { get; set; }
        [Required]
        public string Credit { get; set; }
        public string Description { get; set; }
        
        
        
        [Required]
        public int SemesterId { get; set; }
        public virtual Semester Semester { get; set; }
        [Required]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        
        //public virtual ICollection<CourseAssignToTeacher> CourseAssignToTeachers { get; set; }

    }
}