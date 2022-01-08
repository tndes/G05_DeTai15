using CNPM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CNPM.Controllers
{
    public class DDH_KHController : Controller
    {
        // GET: DDH_KH
        CNPMDOANCUOIKIEntities db = new CNPMDOANCUOIKIEntities();
        public ActionResult Index(string searchBy, string search)
        {
            if (searchBy == "TenKH" )
            {
                return View(db.DonDatHang_KH.Where(s => s.TenKH.Contains(search)).ToList());
            }
            else if (searchBy == "DiaChi" )
                return View(db.DonDatHang_KH.Where(s => s.DiaChi.Contains(search)).ToList());
            else
                return View(db.DonDatHang_KH.ToList());
        }

        // GET: DDH_KH/Details/5
        public ActionResult Details(int id)
        {
            return View(db.ChiTietDDH_KH.Where(s => s.IdDDHKH == id).ToList());
        }

        // GET: DDH_KH/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DDH_KH/Create
        [HttpPost]
        public ActionResult Create(DonDatHang_KH n)
        {
            try
            {
                // TODO: Add insert logic here
                db.DonDatHang_KH.Add(n);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DDH_KH/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.DonDatHang_KH.Where(s => s.IdDDHKH == id).FirstOrDefault());
        }

        // POST: DDH_KH/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, DonDatHang_KH n)
        {
            try
            {
                // TODO: Add update logic here
                var c = db.DonDatHang_KH.Where(s => s.IdDDHKH == id).FirstOrDefault();
                c.IdDDHKH = n.IdDDHKH;
                c.IdKH = n.IdKH;
                c.IdNV = n.IdNV;
                c.TenKH = n.TenKH;
                c.ThoiGianGiaoHang = n.ThoiGianGiaoHang;
                c.DiaChi = n.DiaChi;
                c.PTTT = n.PTTT;
                c.IdVT = n.IdVT;
                c.ChiTietDDH_KH = n.ChiTietDDH_KH;
                c.NhanVien = n.NhanVien;
                c.PhieuXuatKhoes = n.PhieuXuatKhoes;
                c.KhachHang = n.KhachHang;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DDH_KH/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.DonDatHang_KH.Where(s => s.IdDDHKH == id).FirstOrDefault());
        }

        // POST: DDH_KH/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var c = db.DonDatHang_KH.Where(s => s.IdDDHKH == id).FirstOrDefault();
                db.DonDatHang_KH.Remove(c);
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
