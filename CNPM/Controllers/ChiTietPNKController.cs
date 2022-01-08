using CNPM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CNPM.Controllers
{
    public class ChiTietPNKController : Controller
    {
        // GET: ChiTietPNK
        CNPMDOANCUOIKIEntities db = new CNPMDOANCUOIKIEntities();

        public ActionResult Index(string searchBy,string search)
        {
            if (searchBy == "TenVT")
            {
                return View(db.ChiTietPhieuNhapKhoes.Where(s => s.TenVT.Contains(search)).ToList());
            }

            else
                return View(db.ChiTietPhieuNhapKhoes.ToList());


        }

        // GET: ChiTietPNK/Details/5
        public ActionResult Details(int id)
        {
            return View(db.ChiTietPhieuNhapKhoes.Where(s => s.IdCT_PNK == id).ToList());
        }

        // GET: ChiTietPNK/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChiTietPNK/Create
        [HttpPost]
        public ActionResult Create(ChiTietPhieuNhapKho n)
        {
            try
            {
                // TODO: Add insert logic here
                db.ChiTietPhieuNhapKhoes.Add(n);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ChiTietPNK/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.ChiTietPhieuNhapKhoes.Where(s => s.IdCT_PNK == id).FirstOrDefault());
        }

        // POST: ChiTietPNK/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ChiTietPhieuNhapKho n)
        {
            try
            {
                // TODO: Add update logic here
                var c = db.ChiTietPhieuNhapKhoes.Where(s => s.IdCT_PNK == id).FirstOrDefault();
                c.IdCT_PNK = n.IdCT_PNK;
                c.IdPhieuNK = n.IdPhieuNK;
                c.GiaNhap = n.GiaNhap;
                c.SoLuong = n.SoLuong;
                c.TenVT = n.TenVT;
                c.IdDDHNCC = n.IdDDHNCC;
                c.PhieuNhapKho = n.PhieuNhapKho;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ChiTietPNK/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.ChiTietPhieuNhapKhoes.Where(s => s.IdCT_PNK == id).FirstOrDefault());
        }

        // POST: ChiTietPNK/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var c = db.ChiTietPhieuNhapKhoes.Where(s => s.IdCT_PNK == id).FirstOrDefault();
                db.ChiTietPhieuNhapKhoes.Remove(c);
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
