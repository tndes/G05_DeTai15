using CNPM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CNPM.Controllers
{
    public class HoaDonBanHangController : Controller
    {
        // GET: HoaDonBanHang
        CNPMDOANCUOIKIEntities db = new CNPMDOANCUOIKIEntities();

        public ActionResult Index(string searchBy, string search
)
        {

            if (searchBy == "SDT" )
            {
                return View(db.HoaDonBanHangs.Where(s => s.SDT.Contains(search)).ToList());
            }
            else if (searchBy == "DiaChi")
                return View(db.HoaDonBanHangs.Where(s => s.DiaChi.Contains(search)).ToList());
            else if (searchBy == "HoTen")
                return View(db.HoaDonBanHangs.Where(s => s.HoTen.Contains(search)).ToList());
            else
                return View(db.HoaDonBanHangs.ToList());


        }

        // GET: HoaDonBanHang/Details/5
        public ActionResult Details(int id)
        {
            return View(db.ChiTietHoaDons.Where(s => s.IdHD == id).ToList());
        }

        // GET: HoaDonBanHang/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HoaDonBanHang/Create
        [HttpPost]
        public ActionResult Create(HoaDonBanHang n)
        {
            try
            {
                // TODO: Add insert logic here
                db.HoaDonBanHangs.Add(n);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HoaDonBanHang/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.HoaDonBanHangs.Where(s => s.IdHD == id).FirstOrDefault());
        }

        // POST: HoaDonBanHang/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, HoaDonBanHang n)
        {
            try
            {
                // TODO: Add update logic here
                var c = db.HoaDonBanHangs.Where(s => s.IdHD == id).FirstOrDefault();
                c.IdHD = n.IdHD;
                c.HoTen = n.HoTen;
                c.DiaChi = n.DiaChi;
                c.SDT = n.SDT;
                c.TienThueGTGT = n.TienThueGTGT;
                c.ThueSuatGTGT = n.ThueSuatGTGT;
                c.HTTT = n.HTTT;
                c.IdPhieuXK = n.IdPhieuXK;
                c.ChiTietHoaDons = n.ChiTietHoaDons;
                c.PhieuXuatKho = n.PhieuXuatKho;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HoaDonBanHang/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.HoaDonBanHangs.Where(s => s.IdHD == id).FirstOrDefault());
        }

        // POST: HoaDonBanHang/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var c = db.HoaDonBanHangs.Where(s => s.IdHD == id).FirstOrDefault();
                db.HoaDonBanHangs.Remove(c);
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
