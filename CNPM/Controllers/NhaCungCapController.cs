using CNPM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CNPM.Controllers
{
    public class NhaCungCapController : Controller
    {
        // GET: NhaCungCap
        CNPMDOANCUOIKIEntities db = new CNPMDOANCUOIKIEntities();

        public ActionResult Index(string searchBy, string search)
        {

            if (searchBy == "TenNCC")
            {
                return View(db.NhaCungCaps.Where(s => s.TenNCC.Contains(search)).ToList());
            }
            else if (searchBy == "DiaChi")
                return View(db.NhaCungCaps.Where(s => s.DiaChi.Contains(search)).ToList());
            else if (searchBy == "DienThoai")
                return View(db.NhaCungCaps.Where(s => s.DienThoai.Contains(search)).ToList());
            else
                return View(db.NhaCungCaps.ToList());
        }

        // GET: NhaCungCap/Details/5
        public ActionResult Details(int id)
        {
            return View(db.VatTus.Where(s => s.IdNCC == id).ToList());
        }

        // GET: NhaCungCap/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhaCungCap/Create
        [HttpPost]
        public ActionResult Create(NhaCungCap n)
        {
            try
            {
                // TODO: Add insert logic here
                db.NhaCungCaps.Add(n);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NhaCungCap/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.NhaCungCaps.Where(s => s.IdNCC == id).FirstOrDefault());
        }

        // POST: NhaCungCap/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, NhaCungCap n)
        {
            try
            {
                // TODO: Add update logic here
                var c = db.NhaCungCaps.Where(s => s.IdNCC == id).FirstOrDefault();
                c.IdNCC = n.IdNCC;
                c.TenNCC = n.TenNCC;
                c.DiaChi = n.DiaChi;
                c.Email = n.Email;
                c.DienThoai = n.DienThoai;
                c.GhiChu = n.GhiChu;
                c.DonDatHang_NCC = n.DonDatHang_NCC;
                c.VatTus = n.VatTus;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NhaCungCap/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.NhaCungCaps.Where(s => s.IdNCC == id).FirstOrDefault());
        }

        // POST: NhaCungCap/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var c = db.NhaCungCaps.Where(s => s.IdNCC == id).FirstOrDefault();
                db.NhaCungCaps.Remove(c);
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
