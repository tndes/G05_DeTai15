using CNPM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CNPM.Controllers
{
    public class ChiTietDDHNCCController : Controller
    {
        // GET: ChiTietDDHNCC
        CNPMDOANCUOIKIEntities db = new CNPMDOANCUOIKIEntities();

        public ActionResult Index(string searchBy, string search)
        {
            if (searchBy == "TenVatTu")
            {
                return View(db.ChiTietDDH_NCC.Where(s => s.TenVatTu.Contains(search)).ToList());
            }
            
            else
                return View(db.ChiTietDDH_NCC.ToList());
        }

        // GET: ChiTietDDHNCC/Details/5
        public ActionResult Details(int id)
        {
            return View(db.ChiTietDDH_NCC.Where(s => s.IdCTDDH_NCC == id).ToList());
        }

        // GET: ChiTietDDHNCC/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChiTietDDHNCC/Create
        [HttpPost]
        public ActionResult Create(ChiTietDDH_NCC c)
        {
            try
            {
                // TODO: Add insert logic here
                db.ChiTietDDH_NCC.Add(c);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ChiTietDDHNCC/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.ChiTietDDH_NCC.Where(s => s.IdCTDDH_NCC == id).FirstOrDefault());
        }

        // POST: ChiTietDDHNCC/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ChiTietDDH_NCC n)
        {
            try
            {
                // TODO: Add update logic here
                var c = db.ChiTietDDH_NCC.Where(s => s.IdCTDDH_NCC == id).FirstOrDefault();
                c.IdCTDDH_NCC = n.IdCTDDH_NCC;
                c.IdDDHNCC = n.IdDDHNCC;
                c.TenVatTu = n.TenVatTu;
                c.SoLuong = n.SoLuong;
                c.DVT = n.DVT;
                c.DonGia = n.DonGia;
                c.DonDatHang_NCC = n.DonDatHang_NCC;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ChiTietDDHNCC/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.ChiTietDDH_NCC.Where(s => s.IdCTDDH_NCC == id).FirstOrDefault());
        }

        // POST: ChiTietDDHNCC/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var c = db.ChiTietDDH_NCC.Where(s => s.IdCTDDH_NCC == id).FirstOrDefault();
                db.ChiTietDDH_NCC.Remove(c);
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
