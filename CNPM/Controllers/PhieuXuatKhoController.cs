using CNPM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CNPM.Controllers
{
    public class PhieuXuatKhoController : Controller
    {
        // GET: PhieuXuatKho
        CNPMDOANCUOIKIEntities db = new CNPMDOANCUOIKIEntities();

        public ActionResult Index(string searchBy, string search)
        {
            if (searchBy == "HoTenNguoiXuat")
            {
                return View(db.PhieuXuatKhoes.Where(s => s.HoTenNguoiXuat.Contains(search)).ToList());
            }

            else
                return View(db.PhieuXuatKhoes.ToList());
        }

        // GET: PhieuXuatKho/Details/5
        public ActionResult Details(int id)
        {
            return View(db.ChiTietPhieuXuatKhoes.Where(s => s.IdPhieuXK == id).ToList());
        }

        // GET: PhieuXuatKho/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PhieuXuatKho/Create
        [HttpPost]
        public ActionResult Create(PhieuXuatKho n)
        {
            try
            {
                // TODO: Add insert logic here
                db.PhieuXuatKhoes.Add(n);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PhieuXuatKho/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.PhieuXuatKhoes.Where(s => s.IdPhieuXK == id).FirstOrDefault());
        }

        // POST: PhieuXuatKho/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, PhieuXuatKho n)
        {
            try
            {
                // TODO: Add update logic here
                var c = db.PhieuXuatKhoes.Where(s => s.IdPhieuXK == id).FirstOrDefault();
                c.IdPhieuXK = n.IdPhieuXK;
                c.NgayXuatKho = n.NgayXuatKho;
                c.HoTenNguoiXuat = n.HoTenNguoiXuat;
                c.TongSoTien = n.TongSoTien;
                c.SoChungTuGocKem = n.SoChungTuGocKem;
                c.IdDDHKH = n.IdDDHKH;
                c.ChiTietPhieuXuatKhoes = n.ChiTietPhieuXuatKhoes;
                c.DonDatHang_KH = n.DonDatHang_KH;
                c.HoaDonBanHangs = n.HoaDonBanHangs;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PhieuXuatKho/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.PhieuXuatKhoes.Where(s => s.IdPhieuXK == id).FirstOrDefault());
        }

        // POST: PhieuXuatKho/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var c = db.PhieuXuatKhoes.Where(s => s.IdPhieuXK == id).FirstOrDefault();
                db.PhieuXuatKhoes.Remove(c);
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
