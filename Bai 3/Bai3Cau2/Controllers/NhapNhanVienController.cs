using Bai3Cau2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai3Cau2.Controllers
{
    public class NhapNhanVienController : Controller
    {
        // GET: NhapNhanVien
        public ActionResult Index()
        {
            return View();
        }

        // GET: NhapNhanVien/Output
        public ActionResult Output(NhanVien nhanVien)
        {
            nhanVien.maNhanVien = Request["maNhanVien"];
            nhanVien.hoTen = Request["hoTen"];
            nhanVien.ngaySinh = Convert.ToDateTime(Request["ngaySinh"]);
            nhanVien.chucVu = Request["chucVu"];
            nhanVien.gioiTinh = Request["gioiTinh"];
            nhanVien.ngoaiNgu = Request["ngoaiNgu"];
            return View(nhanVien);
        }
    }
}