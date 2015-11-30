using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MVC2.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required]
        public string Name { get; set; }
       // [Remote("emailExists", "Student",ErrorMessage = "Already Exists")]

        [Required(ErrorMessage="Give Email ...")]
        [EmailAddress(ErrorMessage="Invalid Email address..")]
        public string Email { get; set; }
        public string Address { get; set; }
       
        
        
        [Required(ErrorMessage="Enter Department Id..")]

        public int DepartmentId { get; set; }
        public virtual Department Department{ get; set; }   ///why is this/might be foreign key constraint

    
    }
}