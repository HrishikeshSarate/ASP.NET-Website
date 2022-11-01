using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project1.Models;

namespace Project1.Controllers
{
    [RoutePrefix("Home")]                                             //Routing URL: Localhost:41232/Home
    public class HomeController : Controller
    {                                                               
        [Route("")]                                                 //Routing URL: Localhost:41232/Home      
        public ActionResult Index()
        {
            return View();
        }
        [Route("About")]                                            //Routing URL: Localhost:41232/Home/About

        public ActionResult About()
        {
            ViewBag.Message = "About myself.";

            return View();
        }
        [Route("About/Contact")]
        
        public ActionResult Contact()                               //Routing URL: Localhost:41232/Home/About/Contact
        {
            ViewBag.Message = "Contact me.";

            return View();
        }
        [HttpPost]
        public ActionResult SubmitData(Customer cum)
        {
            return View();
        }
    }
}