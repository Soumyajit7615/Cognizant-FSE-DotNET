using ASP_App1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_App1.Controllers       //DO NOT change the namespace name
{
    public class Ex3Controller : Controller         //DO NOT change the class name
    {
        // Implement 'Index' action 
        public ActionResult Index()
        {
            Course course = new Course()
            {
                CourseId = "C101",

                CourseName = "Java",

                Duration = 40,

                Level = "Beginner"
            };
            
            return RedirectToAction("CourseDescription", course);
            
        }
        
        // Implement 'IndexChoice' action
        public ActionResult IndexChoice(int choice)
        {
            if(choice == 1)
            {
                Course course = new Course()
                {
                    CourseId = "C101",
    
                    CourseName = "Java",
    
                    Duration = 40,
    
                    Level = "Beginner"
                };
                
                return RedirectToAction("CourseDescription", course);
            }
            else
            {
                Department department = new Department()
                {

                    CourseList = new List<String>() 
                    { 
                        "Java", "DotNet", "Python", "Ruby"
                    }
                };

                return View("CourseList", department);
            }
        }
        
        // Implement 'CourseDescription' action
        public ActionResult CourseDescription(Course obj)
        {
            return View(obj);
        }
        
        // Implement 'CourseList' action
        public ActionResult CourseList(Department obj)
        {
            return View(obj);
        }
        
    }
}
