using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC2.Models
{
    public class Designation
    {
        public int DesignationId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Teacher> Teachers { set; get; }
    }
}