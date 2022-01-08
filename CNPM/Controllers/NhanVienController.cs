using CNPM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CNPM.Controllers
{
    public class NhanVienController : Controller
    {
        // GET: NhanVien
        CNPMDOANCUOIKIEntities db = new CNPMDOANCUOIKIEntities();

        public ActionResult Index(string searchBy, string search)
        {
            if (searchBy == "TenNV")
            {
                return View(db.NhanViens.Where(s => s.TenNV.Contains(search)).ToList());
            }
            else if (searchBy == "DiaChi")
                return View(db.NhanViens.Where(s => s.DiaChi.Contains(search)).ToList());
            else if (searchBy == "DienThoai")
                return View(db.NhanViens.Where(s => s.DienThoai.Contains(search)).ToList());
            else
                return View(db.NhanViens.ToList());
        }

        // GET: NhanVien/Details/5
        public ActionResult Details(int id)
        { 
            return View(db.DonDatHang_KH.Where(s => s.IdNV == id).FirstOrDefault());
        }

        // GET: NhanVien/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhanVien/Create
        [HttpPost]
        public ActionResult Create(NhanVien n)
        {
            try
            {
                // TODO: Add insert logic here
                db.NhanViens.Add(n);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NhanVien/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.NhanViens.Where(s => s.IdNV == id).FirstOrDefault());
        }

        // POST: NhanVien/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, NhanVien n)
        {
            try
            {
                // TODO: Add update logic here
                var c = db.NhanViens.Where(s => s.IdNV == id).FirstOrDefault();
                c.IdNV = n.IdNV;
                c.TenNV = n.TenNV;
                c.DienThoai = n.DienThoai;
                c.Email = n.Email;
                c.DiaChi = n.DiaChi;
                c.GhiChu = n.GhiChu;
                c.DonDatHang_KH = n.DonDatHang_KH;
                c.DonDatHang_NCC = n.DonDatHang_NCC;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NhanVien/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.NhanViens.Where(s => s.IdNV == id).FirstOrDefault());
        }

        // POST: NhanVien/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var c = db.NhanViens.Where(s => s.IdNV == id).FirstOrDefault();
                db.NhanViens.Remove(c);
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
