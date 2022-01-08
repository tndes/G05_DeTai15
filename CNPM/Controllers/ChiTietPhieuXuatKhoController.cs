using CNPM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CNPM.Controllers
{
    public class ChiTietPhieuXuatKhoController : Controller
    {
        // GET: ChiTietPhieuXuatKho
        CNPMDOANCUOIKIEntities db = new CNPMDOANCUOIKIEntities();

        public ActionResult Index(string searchBy, int search=0)
        {
            if (searchBy == "SoLuong" & search != 0)
            {
                return View(db.ChiTietPhieuXuatKhoes.Where(s => s.SoLuong==(int)search).ToList());
            }
            else if (searchBy == "IdPhieuXK" & search !=0)
                return View(db.ChiTietPhieuXuatKhoes.Where(s => s.IdPhieuXK==search).ToList());
            else
                return View(db.ChiTietPhieuXuatKhoes.ToList());
        }

        // GET: ChiTietPhieuXuatKho/Details/5
        public ActionResult Details(int id)
        {
            return View(db.ChiTietPhieuXuatKhoes.Where(s => s.IdCT_PXK == id).ToList());
        }

        // GET: ChiTietPhieuXuatKho/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChiTietPhieuXuatKho/Create
        [HttpPost]
        public ActionResult Create(ChiTietPhieuXuatKho n)
        {
            try
            {
                // TODO: Add insert logic here
                db.ChiTietPhieuXuatKhoes.Add(n);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ChiTietPhieuXuatKho/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.ChiTietPhieuXuatKhoes.Where(s => s.IdCT_PXK == id).FirstOrDefault());
        }

        // POST: ChiTietPhieuXuatKho/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ChiTietPhieuXuatKho n)
        {
            try
            {
                // TODO: Add update logic here
                var c = db.ChiTietPhieuXuatKhoes.Where(s => s.IdCT_PXK == id).FirstOrDefault();
                c.IdCT_PXK = n.IdCT_PXK;
                c.IdPhieuXK = n.IdPhieuXK;
                c.SoLuong = n.SoLuong;
                c.GiaBan = n.GiaBan;
                c.GiaMua = n.GiaMua;
                c.PhieuXuatKho = n.PhieuXuatKho;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ChiTietPhieuXuatKho/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.ChiTietPhieuXuatKhoes.Where(s => s.IdCT_PXK == id).FirstOrDefault());
        }

        // POST: ChiTietPhieuXuatKho/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var c = db.ChiTietPhieuXuatKhoes.Where(s => s.IdCT_PXK == id).FirstOrDefault();
                db.ChiTietPhieuXuatKhoes.Remove(c);
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
