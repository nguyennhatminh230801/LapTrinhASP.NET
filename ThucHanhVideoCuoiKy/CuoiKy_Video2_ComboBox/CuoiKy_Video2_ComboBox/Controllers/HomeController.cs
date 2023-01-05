using CuoiKy_Video2_ComboBox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CuoiKy_Video2_ComboBox.Controllers
{
    public class HomeController : Controller
    {
        public QLTinhThanh context = new QLTinhThanh();
        public ActionResult Index()
        {
            ViewBag.Tinh = context.Tinhs.ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult loadHuyen(int tinhid)
        {
            return Json(context.Huyens.Where(e => e.TinhID == tinhid).Select(elem => new
            {
                id = elem.HuyenID,
                name = elem.TenHuyen,
            }).ToList(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult loadXa(int huyenid)
        {
            return Json(context.Xas.Where(e => e.HuyenID == huyenid).Select(elem => new
            {
                id = elem.XaID,
                name = elem.TenXa,
            }).ToList(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}