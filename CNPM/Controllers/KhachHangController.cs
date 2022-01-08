using CNPM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CNPM.Controllers
{
    public class KhachHangController : Controller
    {
        // GET: KhachHang
        CNPMDOANCUOIKIEntities db = new CNPMDOANCUOIKIEntities();

        public ActionResult Index(string searchBy, string search)
        {

            if (searchBy == "TenKH")
            {
                return View(db.KhachHangs.Where(s => s.TenKH.Contains(search)).ToList());
            }
            else if (searchBy == "DiaChi")
                return View(db.KhachHangs.Where(s => s.DiaChi.Contains(search)).ToList());
            else if (searchBy == "DienThoai")
                return View(db.KhachHangs.Where(s => s.DienThoai.Contains(search)).ToList());
            else
                return View(db.KhachHangs.ToList());
        }

        // GET: KhachHang/Details/5
        public ActionResult Details(int id)
        {
            return View(db.DonDatHang_KH.Where(s => s.IdKH==id).ToList());
        }

        // GET: KhachHang/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KhachHang/Create
        [HttpPost]
        public ActionResult Create(KhachHang k)
        {
            try
            {
                // TODO: Add insert logic here
                db.KhachHangs.Add(k);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: KhachHang/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.KhachHangs.Where(s => s.IdKH == id).FirstOrDefault());
        }

        // POST: KhachHang/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, KhachHang k)
        {
            try
            {
                // TODO: Add update logic here
                var c = db.KhachHangs.Where(s => s.IdKH == id).FirstOrDefault();
                c.IdKH = k.IdKH;
                c.TenKH = k.TenKH;
                c.DiaChi = k.DiaChi;
                c.DienThoai = k.DienThoai;
                c.Email = k.Email;
                c.GhiChu = k.GhiChu;
                c.DonDatHang_KH = k.DonDatHang_KH;

                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: KhachHang/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.KhachHangs.Where(s => s.IdKH == id).FirstOrDefault());
        }

        // POST: KhachHang/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var c = db.KhachHangs.Where(s => s.IdKH == id).FirstOrDefault();
                db.KhachHangs.Remove(c);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
