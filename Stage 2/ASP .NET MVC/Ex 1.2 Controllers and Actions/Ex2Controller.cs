using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASP_App1.Controllers            //DO NOT change the namespace name
{
    public class Ex2Controller : Controller     //DO NOT change the class name
    {
        
        // Implement 'Course' action
        public ActionResult Course(int id)
        {
            if(id == 1)
            {
                return RedirectToAction("JavaCourse");
            }
            else
            {
                return RedirectToAction("DotNetCourse");
            }
        }
        
        // Implement 'JavaCourse' action
        public ActionResult JavaCourse()
        {
            return View();
        }
        
        // Implement 'DotNetCourse' action
        public ActionResult DotNetCourse()
        {
            return View();
        }
    }
}
