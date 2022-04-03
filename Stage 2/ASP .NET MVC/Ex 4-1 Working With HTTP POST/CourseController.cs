using ASP_App1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_App1.Controllers               //DO NOT change the namespace name
{
    public class CourseController : Controller    //DO NOT change the class name
    {
        // Implement 'Course' action
        [HttpGet]
        public ActionResult Course()
        {
            return View();
        }

       // Implement 'Course' action as Http POST
       public ActionResult Course(Course course)
       {
           return View(course);
       }
    }
}
