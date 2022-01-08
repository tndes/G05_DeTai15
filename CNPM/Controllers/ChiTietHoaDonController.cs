using CNPM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CNPM.Controllers
{
    public class ChiTietHoaDonController : Controller
    {
        // GET: ChiTietHoaDon
        CNPMDOANCUOIKIEntities db = new CNPMDOANCUOIKIEntities();

        public ActionResult Index(string searchBy, string search)
        {
            if (searchBy == "TenVT")
            {
                return View(db.ChiTietHoaDons.Where(s => s.TenVT.StartsWith(search)).ToList());
            }
            else
                return View(db.ChiTietHoaDons.ToList());
        }

        // GET: ChiTietHoaDon/Details/5
        public ActionResult Details(int id)
        {
            return View(db.ChiTietHoaDons.Where(s => s.IdCTHD == id).ToList());
        }

        // GET: ChiTietHoaDon/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChiTietHoaDon/Create
        [HttpPost]
        public ActionResult Create(ChiTietHoaDon n)
        {
            try
            {
                // TODO: Add insert logic here
                db.ChiTietHoaDons.Add(n);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ChiTietHoaDon/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.ChiTietHoaDons.Where(s => s.IdCTHD == id).FirstOrDefault());
        }

        // POST: ChiTietHoaDon/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ChiTietHoaDon n)
        {
            try
            {
                // TODO: Add update logic here
                var c = db.ChiTietHoaDons.Where(s => s.IdCTHD == id).FirstOrDefault();
                c.IdCTHD = n.IdCTHD;
                c.SoLuong = n.SoLuong;
                c.DVT = n.DVT;
                c.DonGia = n.DonGia;
                c.TenVT = n.TenVT;
                c.HoaDonBanHang = n.HoaDonBanHang;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ChiTietHoaDon/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.ChiTietHoaDons.Where(s => s.IdCTHD == id).FirstOrDefault());
        }

        // POST: ChiTietHoaDon/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var c = db.ChiTietHoaDons.Where(s => s.IdCTHD == id).FirstOrDefault();
                db.ChiTietHoaDons.Remove(c);
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
