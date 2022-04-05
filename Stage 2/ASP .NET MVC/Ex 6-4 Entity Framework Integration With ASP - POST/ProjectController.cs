using ASP_EF_App1.DAL;
using ASP_EF_App1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_EF_App1.Controllers      //DO NOT change the namespace name
{
    public class ProjectController : Controller //DO NOT change the class name
    {
        // Implement 'ProjectDetail' action
        public ActionResult ProjectDetail()
        {
            return View("AddProjectDetails");
        }
        // Implement 'ProjectDetail' action with HttpPost
        [HttpPost]
        public ActionResult ProjectDetail(Project project)
        {
            var projectContext = new ProjectContext();
            project.ProjectId = 1;
            projectContext.Projects.Add(project);
            projectContext.SaveChanges();
            return View("ViewProjectDetails", project);
        }
    }
}
