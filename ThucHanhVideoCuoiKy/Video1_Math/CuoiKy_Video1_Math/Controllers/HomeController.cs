using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CuoiKy_Video1_Math.Controllers
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

        public ActionResult Math(int n1, int n2)
        {
            var x = n1 + n2;
            var result = n1 + " + " + n2 + " = " + x;
            var data = new { status = "ok", result = result };
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}