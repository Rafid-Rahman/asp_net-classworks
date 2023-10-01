using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RegistrationForm.Models;

namespace RegistrationForm.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }

        /*
        [HttpPost]
        public ActionResult Registration(FormCollection fc)
        {
            ViewBag.Uname = fc["Username"];
            ViewBag.Upass = fc["Password"];
            ViewBag.Uid = fc["Id"];
            ViewBag.Ugender = fc["Gender"];
            ViewBag.Uprofession = fc["Profession"];
            ViewBag.Uhobbies = fc["Hobbies"];
            return View();
        }
        */
        [HttpPost]
        public ActionResult Registration(Registration m)
        {
            return View(m);
        }
    }
}
 