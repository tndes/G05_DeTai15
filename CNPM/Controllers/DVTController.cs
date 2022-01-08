using CNPM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CNPM.Controllers
{
    public class DVTController : Controller
    {
        // GET: DVT
        CNPMDOANCUOIKIEntities db = new CNPMDOANCUOIKIEntities();
        public ActionResult Index(string searchBy, string search)
        {

            if (searchBy == "DonVi")
            {
                return View(db.DonViTinhs.Where(s => s.DonVi.Contains(search)).ToList());
            }
            
            else
                return View(db.DonViTinhs.ToList());

        }

        // GET: DVT/Details/5
        public ActionResult Details(int id)
        {
            return View(db.DonViTinhs.Where(s => s.IdDVT == id).ToList());
        }

        // GET: DVT/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DVT/Create
        [HttpPost]
        public ActionResult Create(DonViTinh v)
        {
            try
            {
                // TODO: Add insert logic here
                db.DonViTinhs.Add(v);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DVT/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.DonViTinhs.Where(s => s.IdDVT == id).FirstOrDefault());
        }

        // POST: DVT/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, DonViTinh n)
        {
            try
            {
                // TODO: Add update logic here
                var c = db.DonViTinhs.Where(s => s.IdDVT == id).FirstOrDefault();
                c.IdDVT = n.IdDVT;
                c.DonVi = n.DonVi;
                c.VatTus = n.VatTus;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DVT/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.DonViTinhs.Where(s => s.IdDVT == id).FirstOrDefault());
        }

        // POST: DVT/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var c = db.DonViTinhs.Where(s => s.IdDVT == id).FirstOrDefault();
                db.DonViTinhs.Remove(c);
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
