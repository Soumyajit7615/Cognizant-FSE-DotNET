using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_App1.Controllers            //DO NOT change the namespace name
{
    
    public class HomeController : Controller       //DO NOT change the class name
    {

        // DO NOT change the following declaration and values
        String business = "Flipkart";
        String type = "E-commerce";
        int founded = 2007;
        String website = "www.flipkart.com";


        // Implement 'About' action with Route 'flipkart/info'
        [Route("flipkart/info")]
        public ActionResult About()
        {
            ViewBag.Business = business;
            ViewBag.Type = type;
            ViewBag.Founded = founded;
            ViewBag.Website = website;
            
            return View();
        }
    }
}
