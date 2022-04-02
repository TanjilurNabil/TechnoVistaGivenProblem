using _3N.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3N.Controllers
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
        public ActionResult probSolution()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        public long Calculation(InputModel model)
        {
            var data = ResultCalculation.maxCycleLength(model.Input1, model.Input2);
            return data;
        }
    }
}