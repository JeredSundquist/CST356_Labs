using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _CST356____Lab1.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Person()
        {
            ViewBag.Message = "Jon Doe";
            ViewBag.Message = "Jane Doe";

            return View();
        }
    }
}