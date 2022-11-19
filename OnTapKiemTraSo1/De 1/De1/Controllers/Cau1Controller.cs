using De1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace De1.Controllers
{
    public class Cau1Controller : Controller
    {
        // GET: Cau1
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Output()
        {
            var hangHoa = new HangHoa();
            hangHoa.MaHang = Convert.ToString(Request["maHang"]);
            hangHoa.TenHang = Convert.ToString(Request["tenHang"]);
            hangHoa.LoaiHang = Convert.ToString(Request["loaiHang"]);
            hangHoa.SoLuong = Convert.ToInt32(Request["soLuong"]);
            hangHoa.DonGia = Convert.ToDouble(Request["donGia"]);
            return View(hangHoa);
        }
    }
}