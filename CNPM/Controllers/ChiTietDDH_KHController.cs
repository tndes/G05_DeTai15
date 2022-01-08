using CNPM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CNPM.Controllers
{
    public class ChiTietDDH_KHController : Controller
    {
        // GET: ChiTietDDH_KH
        CNPMDOANCUOIKIEntities db = new CNPMDOANCUOIKIEntities();

        public ActionResult Index(string searchBy, string search)
        {
            if (searchBy == "TenVatTu")
            {
                return View(db.ChiTietDDH_KH.Where(s => s.TenVatTu.Contains(search)).ToList());
            }
           
            else
                return View(db.ChiTietDDH_KH.ToList());
        }

        // GET: ChiTietDDH_KH/Details/5
        public ActionResult Details(int id)
        {
            return View(db.ChiTietDDH_KH.Where(s => s.IdCTDDH_KH == id).ToList());
        }

        // GET: ChiTietDDH_KH/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChiTietDDH_KH/Create
        [HttpPost]
        public ActionResult Create(ChiTietDDH_KH n)
        {
            try
            {
                // TODO: Add insert logic here
                db.ChiTietDDH_KH.Add(n);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ChiTietDDH_KH/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.ChiTietDDH_KH.Where(s => s.IdCTDDH_KH == id).FirstOrDefault());
        }

        // POST: ChiTietDDH_KH/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ChiTietDDH_KH m)
        {
            try
            {
                // TODO: Add update logic here
                var c = db.ChiTietDDH_KH.Where(s => s.IdCTDDH_KH == id).FirstOrDefault();
                c.IdCTDDH_KH = m.IdCTDDH_KH;
                c.TenVatTu = m.TenVatTu;
                c.SoLuong = m.SoLuong;
                c.DonGia = m.DonGia;
                c.TongCong = m.TongCong;
                c.IdDDHKH = m.IdDDHKH;
                c.DonDatHang_KH = m.DonDatHang_KH;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ChiTietDDH_KH/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.ChiTietDDH_KH.Where(s => s.IdCTDDH_KH == id).FirstOrDefault());
        }

        // POST: ChiTietDDH_KH/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var c = db.ChiTietDDH_KH.Where(s => s.IdCTDDH_KH == id).FirstOrDefault();
                db.ChiTietDDH_KH.Remove(c);
                db.SaveChanges();
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
