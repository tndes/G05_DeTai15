using CNPM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CNPM.Controllers
{
    public class DonDHNCCController : Controller
    {
        // GET: DonDHNCC
        CNPMDOANCUOIKIEntities db = new CNPMDOANCUOIKIEntities();

        public ActionResult Index(string searchBy, string search)
        {
            if (searchBy == "TenCongTy")
            {
                return View(db.DonDatHang_NCC.Where(s => s.TenCongTy.Contains(search)).ToList());
            }
            else if (searchBy == "DiaDiemGiao")
                return View(db.DonDatHang_NCC.Where(s => s.DiaDiemGiaoHang.Contains(search)).ToList());
            else
                return View(db.DonDatHang_NCC.ToList());
        }

        // GET: DonDHNCC/Details/5
        public ActionResult Details(int id)
        {
            return View(db.ChiTietDDH_NCC.Where(s => s.IdDDHNCC == id).ToList());
        }

        // GET: DonDHNCC/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DonDHNCC/Create
        [HttpPost]
        public ActionResult Create(DonDatHang_NCC n)
        {
            try
            {
                // TODO: Add insert logic here
                db.DonDatHang_NCC.Add(n);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DonDHNCC/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.DonDatHang_NCC.Where(s => s.IdDDHNCC == id).FirstOrDefault());
        }

        // POST: DonDHNCC/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, DonDatHang_NCC n)
        {
            try
            {
                // TODO: Add update logic here
                var c = db.DonDatHang_NCC.Where(s => s.IdDDHNCC == id).FirstOrDefault();
                c.IdDDHNCC = n.IdDDHNCC;
                c.TongTien = n.TongTien;
                c.TenCongTy = n.TenCongTy;
                c.ThoiGianGiaoHang = n.ThoiGianGiaoHang;
                c.DiaDiemGiaoHang = n.DiaDiemGiaoHang;
                c.IdNV = n.IdNV;
                c.IdNCC = n.IdNCC;
                c.ChiTietDDH_NCC = n.ChiTietDDH_NCC;
                c.NhanVien = n.NhanVien;
                c.NhaCungCap = n.NhaCungCap;
                c.PhieuNhapKhoes = n.PhieuNhapKhoes;
                db.SaveChanges();


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DonDHNCC/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.DonDatHang_NCC.Where(s => s.IdDDHNCC == id).FirstOrDefault());
        }

        // POST: DonDHNCC/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var c = db.DonDatHang_NCC.Where(s => s.IdDDHNCC == id).FirstOrDefault();
                db.DonDatHang_NCC.Remove(c);
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
