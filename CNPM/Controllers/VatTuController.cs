using CNPM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CNPM.Controllers
{
    public class VatTuController : Controller
    {
        // GET: VatTu
        CNPMDOANCUOIKIEntities db = new CNPMDOANCUOIKIEntities();


        public ActionResult Index(string searchBy, string search)
        {
            if (searchBy == "TenVT")
            {
                return View(db.VatTus.Where(s => s.TenVT.Contains(search)).ToList());
            }
           
            else
                return View(db.VatTus.ToList());
        }

        // GET: VatTu/Details/5
        public ActionResult Details(int id)
        {
            return View(db.DonViTinhs.Where(s => s.IdDVT == id).ToList());
        }

        // GET: VatTu/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VatTu/Create
        [HttpPost]
        public ActionResult Create(VatTu v)
        {
            try
            {
                // TODO: Add insert logic here
                db.VatTus.Add(v);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: VatTu/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.VatTus.Where(s => s.IdVT == id).FirstOrDefault());
        }

        // POST: VatTu/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, VatTu n)
        {
            try
            {
                // TODO: Add update logic here
                var c = db.VatTus.Where(s => s.IdVT == id).FirstOrDefault();
                c.IdVT = n.IdVT;
                c.IdDVT = n.IdDVT;
                c.TenVT = n.TenVT;
                c.GiaBan = n.GiaBan;
                c.GiaMua = n.GiaMua;
                c.SoLuong = n.SoLuong;
                c.IdNCC = n.IdNCC;
                c.DonViTinh = n.DonViTinh;
                c.NhaCungCap = n.NhaCungCap;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: VatTu/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.VatTus.Where(s => s.IdVT == id).FirstOrDefault());
        }

        // POST: VatTu/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var c = db.VatTus.Where(s => s.IdVT == id).FirstOrDefault();
                db.VatTus.Remove(c);
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
