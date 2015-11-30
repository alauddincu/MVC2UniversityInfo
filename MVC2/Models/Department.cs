using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.UI.WebControls;

namespace MVC2.Models
{
    public class Department
    {

        public int DepartmentId { set; get; }

        [Required(ErrorMessage = "enter department Code..")]
        public string Code { set; get; }

        [DisplayName("Department Name")]
        [Required(ErrorMessage = "Pls enter name")]
        public string Name { set; get; }

        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Student> Students { set; get; }
        //public virtual ICollection<CourseAssignToTeacher> CourseAssignToTeachers{ get; set; }


    }
}