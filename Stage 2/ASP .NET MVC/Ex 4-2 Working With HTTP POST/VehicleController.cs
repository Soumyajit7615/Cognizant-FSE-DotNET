using ASP_App1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_App1.Controllers                      //DO NOT change the namespace name
{
    public class VehicleController : Controller    //DO NOT change the class name
    {
        // Implement 'Registration' action
        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }
        
        // Implement 'Registration' action as Http POST
        [HttpPost]
        public ActionResult Registration(Registration registration)
        {
            
            ViewBag.CustomerName = registration.CustomerName;
            ViewBag.PhoneNumber = registration.PhoneNumber;
            ViewBag.VehicleNo = registration.VehicleNo;
            ViewBag.City = registration.City;
            ViewBag.VehicleModel = registration.VehicleModel;
            ViewBag.ServiceType = registration.ServiceType;
            
            return View("Confirm");

        }
    }
}
