using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Curs7.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [ActionName("about")]
        public ActionResult SomeMethodName()
        {
            return View("");

        }
        [NonAction]
        public double Calc()
        {
            return 1 + 2 + 3 + 4 + 5;
        }
        [HttpGet]
        public ActionResult VerbsTest()
        {
            return View();
        }
       //Tema: Cursul 7 . Exercitiul 5
        //[ActionName("Authorize")]
        [Authorize(Roles ="Admin")]
        public ActionResult ThisMethodNeedsAuthorization()
        {
            return Content("Hello!");
        }
    }
}
