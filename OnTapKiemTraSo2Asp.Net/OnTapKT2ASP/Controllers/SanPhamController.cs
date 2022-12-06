using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnTapKT2ASP.Models;
using PagedList;
using PagedList.Mvc;

namespace OnTapKT2ASP.Controllers
{
    public class SanPhamController : Controller
    {
        private QLSanPhamDB db = new QLSanPhamDB();

        // GET: SanPham
        public ActionResult Index(int? page, string search, string current)
        {
            var sanphams = db.Sanphams.Include(s => s.Danhmuc);

            var pageNumber = (page ?? 1);
            var pageSize = 3;

            if (search != null)
            {
                page = 1;
            }
            else
            {
                search = current;
            }

            ViewBag.Current = search;

            if (!string.IsNullOrEmpty(search))
            {
                sanphams = sanphams.Where(s => s.Tenvd.Contains(search));
            }

            sanphams = sanphams.OrderBy(s => s.Mavd);
            return View(sanphams.ToPagedList(pageNumber, pageSize));
        }

        // GET: SanPham/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sanpham sanpham = db.Sanphams.Find(id);
            if (sanpham == null)
            {
                return HttpNotFound();
            }
            return View(sanpham);
        }

        // GET: SanPham/Create
        public ActionResult Create()
        {
            ViewBag.MaDanhmuc = new SelectList(db.Danhmucs, "MaDanhmuc", "TenDanhmuc");
            return View();
        }

        // POST: SanPham/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Mavd,Tenvd,TenAnh,Mota,Giatien,Soluong,MaDanhmuc")] Sanpham sanpham)
        {
            if (ModelState.IsValid)
            {
                var fileAnh = Request.Files["TenAnh"];
                
                if (fileAnh != null && fileAnh.ContentLength > 0)
                {
                    string tenAnh = System.IO.Path.GetFileName(fileAnh.FileName);

                    string duongDanUploadAnh = Server.MapPath("~/Content/Images/" + tenAnh);

                    fileAnh.SaveAs(duongDanUploadAnh);

                    sanpham.TenAnh = tenAnh;
                }

                db.Sanphams.Add(sanpham);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaDanhmuc = new SelectList(db.Danhmucs, "MaDanhmuc", "TenDanhmuc", sanpham.MaDanhmuc);
            return View(sanpham);
        }

        // GET: SanPham/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sanpham sanpham = db.Sanphams.Find(id);
            if (sanpham == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaDanhmuc = new SelectList(db.Danhmucs, "MaDanhmuc", "TenDanhmuc", sanpham.MaDanhmuc);
            return View(sanpham);
        }

        // POST: SanPham/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Mavd,Tenvd,TenAnh,Mota,Giatien,Soluong,MaDanhmuc")] Sanpham sanpham)
        {
            if (ModelState.IsValid)
            {
                var fileAnh = Request.Files["TenAnh"];

                if (fileAnh != null && fileAnh.ContentLength > 0)
                {
                    string tenAnh = System.IO.Path.GetFileName(fileAnh.FileName);

                    string duongDanUploadAnh = Server.MapPath("~/Content/Images/" + tenAnh);

                    fileAnh.SaveAs(duongDanUploadAnh);

                    sanpham.TenAnh = tenAnh;
                }

                db.Entry(sanpham).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaDanhmuc = new SelectList(db.Danhmucs, "MaDanhmuc", "TenDanhmuc", sanpham.MaDanhmuc);
            return View(sanpham);
        }

        // GET: SanPham/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sanpham sanpham = db.Sanphams.Find(id);
            if (sanpham == null)
            {
                return HttpNotFound();
            }
            return View(sanpham);
        }

        // POST: SanPham/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sanpham sanpham = db.Sanphams.Find(id);
            db.Sanphams.Remove(sanpham);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
