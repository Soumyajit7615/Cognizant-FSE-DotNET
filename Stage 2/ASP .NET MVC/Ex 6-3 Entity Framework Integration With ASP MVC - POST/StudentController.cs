using ASP_EF_App1.DAL;
using ASP_EF_App1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_EF_App1.Controllers   //DO NOT change the namespace name
{
    public class StudentController : Controller     //DO NOT change the class name
    {
        
        // Implement 'Index' action.
        public ActionResult Index()
        {
            
            Student student = new Student()
            {
                StudentName="Johana",
                Department="Art",
                PhoneNumber=9876565434,
                EnrolledDate=Convert.ToDateTime("06/25/2018")
            };
            
            return RedirectToAction("AddDetail", student);
        
        }
        
        // Implement 'AddDetail' action
        public ActionResult AddDetail(Student student)
        {
            CollegeContext collegeContext=new CollegeContext();
            collegeContext.Students.Add(student);
            collegeContext.SaveChanges();
            
            return View("ViewDetails",student);
        }
    }
}
