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
    }
}