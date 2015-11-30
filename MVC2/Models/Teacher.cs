using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using  System.ComponentModel.DataAnnotations;

namespace MVC2.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        [Required]
        public string Name { get; set; }
         [Required]
        public string Address { get; set; }
         [Required]
        [EmailAddress]
        public string Email { get; set; }
         [Required]
        public string ContactNo { get; set; }
         [Required]
        public double Credit { get; set; }
       
        
        
        [Required]
        public int DesignationId { get; set; }
         [Required]
        public int DepartmentId { get; set; }
        public virtual Designation Designation { get; set; }
        public virtual Department Department { get; set; }
       // public virtual ICollection<CourseAssignToTeacher> AssignToTeachers { get; set; }





    }
}
