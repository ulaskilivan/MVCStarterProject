using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCStarter.Models.Entity;
namespace MVCStarter.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        MvcDBStokEntities db = new MvcDBStokEntities();
        public ActionResult Index()
        {
            var values = db.TBLURUNLERs.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult UrunEkle() { return View(); }
        [HttpPost]
        public ActionResult UrunEkle(TBLURUNLER p1)
        {
            db.TBLURUNLERs.Add(p1);
            db.SaveChanges();
            return View();
        }
    }
}