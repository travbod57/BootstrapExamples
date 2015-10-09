using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BootstrapExamples.Models;

namespace BootstrapExamples.Controllers
{
    public class ComponentController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Datepicker()
        {
            return View();
        }

        public ActionResult TypeAhead()
        {
            SingleStateVM vm = new SingleStateVM() { StateName = "New York", StateId = 32 };
            return View(vm);
        }

        [HttpPost]
        public ActionResult TypeAhead(SingleStateVM vm)
        {
            return View();
        }


        public ActionResult TypeAheadWithBloodhound()
        {
            return View();
        }

        public ActionResult TagsInputBasic()
        {
            TagsMultipleStateVM vm = new TagsMultipleStateVM() { StateIds = "a,b,c" };
            return View(vm);
        }

        public ActionResult TagsInputTypeAhead()
        {
            return View();
        }

        public ActionResult TagsInputTypeAheadBloodhound()
        {
            return View();
        }
    }
}
