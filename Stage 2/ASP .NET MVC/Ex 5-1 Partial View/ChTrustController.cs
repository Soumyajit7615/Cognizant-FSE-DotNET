using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_App1.Controllers          //DO NOT change the namespace name
{
    public class ChTrustController : Controller         //DO NOT change the class name
    {
        // Implement 'ChTrust' action
        public ActionResult ChTrust()
        {
            return View();
        }
        
        // Implement 'HeaderNavBar' action
        public PartialViewResult _HeaderNavBar()
        {
            return PartialView();
        }
        
        // Implement 'FooterNavBar' action
        public PartialViewResult _FooterNavBar()
        {
            return PartialView();
        }
        
    }
}
