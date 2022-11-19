using De2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace De2.Controllers
{
    public class SanPhamController : Controller
    {
        private List<SanPham> sanPhams;
        public SanPhamController()
        {
            sanPhams = new List<SanPham>();
            sanPhams.Add(new SanPham("SP01", "RealMe", 100, 200));
            sanPhams.Add(new SanPham("SP02", "Nokia 2660", 50, 150));
            sanPhams.Add(new SanPham("SP03", "Oppo Reno4", 70, 160));
        }

        // GET: SanPham
        public ActionResult Index()
        {
            return View(sanPhams);
        }
        
        public ActionResult HienThiHaiDanhSach()
        {
            return View(sanPhams);
        }
    }
}