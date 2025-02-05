using ASP_EF_App1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP_EF_App1.DAL         //DO NOT change the namespace name
{
    public class CollegeContext :DbContext          //DO NOT change the class name
    {
        public CollegeContext() : base("CollegeContext")        //DO NOT change the context name
        {
        }
        
        //Implement property for 'Placements' with required declaration
        public DbSet<Placement> Placements { get; set; }
    }
}
