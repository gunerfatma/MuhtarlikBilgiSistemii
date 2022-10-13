using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuhtarlikBilgiSistemi1.Controllers
{
    public class MuhtarMahalleController : Controller
    {
        MahalleManager mahalleManager = new MahalleManager(new EfMahalleDal());
        
        // GET: Mahalle

        public ActionResult Index()
        {
            var mahallevalues = mahalleManager.GetListMahalle();
            return View(mahallevalues);
        }
    }
}