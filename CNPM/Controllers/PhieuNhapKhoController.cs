using CNPM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CNPM.Controllers
{
    public class PhieuNhapKhoController : Controller
    {
        // GET: PhieuNhapKho
        CNPMDOANCUOIKIEntities db = new CNPMDOANCUOIKIEntities();

        public ActionResult Index(string searchBy, string search)
        {


            if (searchBy == "TenNguoiNhap")
            {
                return View(db.PhieuNhapKhoes.Where(s => s.TenNguoiNhap.Contains(search)).ToList());
            }

            else
                return View(db.PhieuNhapKhoes.ToList());
        }

        // GET: PhieuNhapKho/Details/5
        public ActionResult Details(int id)
        {
            return View(db.ChiTietPhieuNhapKhoes.Where(s => s.IdPhieuNK == id).ToList());
        }

        // GET: PhieuNhapKho/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PhieuNhapKho/Create
        [HttpPost]
        public ActionResult Create(PhieuNhapKho n)
        {
            try
            {
                // TODO: Add insert logic here
                db.PhieuNhapKhoes.Add(n);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PhieuNhapKho/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.PhieuNhapKhoes.Where(s => s.IdPhieuNK == id).FirstOrDefault());
        }

        // POST: PhieuNhapKho/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, PhieuNhapKho n)
        {
            try
            {
                // TODO: Add update logic here
                var c = db.PhieuNhapKhoes.Where(s => s.IdPhieuNK == id).FirstOrDefault();
                c.IdPhieuNK = n.IdPhieuNK;
                c.TenNguoiNhap = n.TenNguoiNhap;
                c.Tong = n.Tong;
                c.NgayNhapKho = n.NgayNhapKho;
                c.IdDDHNCC = n.IdDDHNCC;
                c.ChiTietPhieuNhapKhoes = n.ChiTietPhieuNhapKhoes;
                c.DonDatHang_NCC = n.DonDatHang_NCC;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PhieuNhapKho/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.PhieuNhapKhoes.Where(s => s.IdPhieuNK == id).FirstOrDefault());
        }

        // POST: PhieuNhapKho/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var c = db.PhieuNhapKhoes.Where(s => s.IdPhieuNK == id).FirstOrDefault();
                db.PhieuNhapKhoes.Remove(c);
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
