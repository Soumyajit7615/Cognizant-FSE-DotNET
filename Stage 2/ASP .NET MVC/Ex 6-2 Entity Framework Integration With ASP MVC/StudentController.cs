using ASP_EF_App1.DAL;
using ASP_EF_App1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_EF_App1.Controllers            //DO NOT change the namespace name
{
    public class StudentController : Controller     //DO NOT change the class name
    {
        public ActionResult Placement()
        {
            /**  DO NOT REMOVE THE BELOW 2 LINES **/
            StudentDAO sd = new StudentDAO();
            sd.AddPlacements();
            /**   END OF 2 LINES  **/
            

            //Implement code here
            CollegeContext collegeContext = new CollegeContext();
            
            List<Placement> listOfPlacement = collegeContext.Placements.OrderBy(p => p.PlacementId).ToList();
            
            return View(listOfPlacement);
            
        }
    }
}
