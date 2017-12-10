using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Spring.Mvc3QuickStart.Models;

namespace Spring.Mvc3QuickStart.Controllers
{   
    public class User
    {
        public String Name { get; set; }
        public int Age { get; set; }
    }

    public class HomeController : Controller
    {   
        //public HomeController()
        //{

        //}
        public HomeController(int count, string category, User activeUse)
        {
            int i = 0;
        }
        public string Message { get; set; }

        public ActionResult Index()
        {
            //simple asp.net mvc sample app hard-coded message commented out b/c we
            // can property-inject it via the container instead
            // (gratuitous container usage trick, but demonstrates that the container
            //  is resolving HomeController)
            
            //ViewData["Message"] = "Welcome to ASP.NET MVC!";

            //set the message value in the viewdata bag based on the property value
            // as injected into the controller from the container
            ViewData["Message"] = Message;

            return View();
        }

        public ActionResult InterestedArticles(string district)
        {
            List<Articles> articles = new List<Articles> { new Articles { Description = "Dynasty Bowl", Id = Guid.NewGuid() },
                new Articles {Description = "Aged Auto Chrysler", Id = Guid.NewGuid() } };
            return View(articles);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
