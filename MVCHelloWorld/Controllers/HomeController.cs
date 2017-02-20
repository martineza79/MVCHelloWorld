using MVCHelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHelloWorld.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var cars = HelloModel.GetCars();
            ViewBag.HelloWorld = "Hello World";// This is the second way to render "Hello World" on the Index.cshtml view
            return View(cars);
        }
    }
}