using System.Web.Mvc;

namespace Bai2.Controllers
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

        public ActionResult Cau1()
        {
            return RedirectToAction("Index", "Cau1");
        }

        public ActionResult Cau2()
        {
            return RedirectToAction("Index", "Cau2");
        }

        public ActionResult Cau3()
        {
            return RedirectToAction("Index", "Cau3");
        }

        public ActionResult Cau4()
        {
            return RedirectToAction("Index", "Cau4");
        }
    }
}