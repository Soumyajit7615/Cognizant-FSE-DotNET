using ASP_App1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_App1.Controllers           //DO NOT change the namespace name
{
    public class Ex3Controller : Controller       //DO NOT change the class name
    {
        //DO NOT change the below variable declaration and values
        List<ShoppingCart> l1 = new List<ShoppingCart>() 
        {
            new ShoppingCart("CA1","Shoe",3000,"Sport"),
            new ShoppingCart("CA2", "Shirt", 1500, "Men's Wear"),
            new ShoppingCart("CA3","Watch",4000,"Accessories"),
            new ShoppingCart("CA4","Samsung",15000,"Mobiles")
        };
        
        // Implement 'Cart' action
        
        public ActionResult Cart(int id)
        {
            return View("Cart", l1[id - 1]);
        }
        
       // Implement 'Cart' action as Http POST
       [HttpPost]
        public ActionResult Cart(ShoppingCart shoppingCart)
        {
            return View(shoppingCart);
        }
    }
}
