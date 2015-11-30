using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC2.Models;

namespace MVC2.Controllers
{
    public class UniversityDeptController : Controller
    {
        //
        // GET: /UniversotyDept/
        public ActionResult All()
        {
            UniversityDbContext db = new UniversityDbContext();
            return View(db.Departments.ToList());
        }
	}
}