using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCStarter.Models.Entity;

namespace MVCStarter.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        MvcDBStokEntities db=new MvcDBStokEntities();
        public ActionResult Index()
        {
            var values = db.TBLKATEGORILERs.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult YeniKategori()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniKategori(TBLKATEGORILER p1)
        {
            db.TBLKATEGORILERs.Add(p1);
            db.SaveChanges();
            return View();
        }
    }
}