using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCStarter.Models.Entity;
namespace MVCStarter.Controllers
{
    public class MusteriController : Controller
    {
        // GET: Musteri
        MvcDBStokEntities db = new MvcDBStokEntities();

        public ActionResult Index()
        {
            var values = db.TBLMUSTERILERs.ToList();
            return View(values);
        }
    }
}