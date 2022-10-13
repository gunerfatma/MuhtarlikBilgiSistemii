using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuhtarlikBilgiSistemi1.Controllers
{

    [AllowAnonymous]
    public class KullanıcıController : Controller
    {
        MuhtarManager mm = new MuhtarManager(new EfMuhtarDal());
        MahalleManager mahalleManager = new MahalleManager(new EfMahalleDal());
        EnvanterManager envanterManager = new EnvanterManager(new EfEnvanterDal());
        OnemliMekanlarManager onemliMekanlarManager = new OnemliMekanlarManager(new EfOnemliMekanlarDal());
        HizmetlerManager hm = new HizmetlerManager(new EfHizmetlerDal());


        // GET: Kullanıcı

        public ActionResult KullanıcıMuhtar()
        {
            var MuhtarValues = mm.GetList();
            return View(MuhtarValues);
           // return View();
        }

        public ActionResult KullanıcıMahalle()
        {
            var mahallevalues = mahalleManager.GetList();
            return View(mahallevalues);
        }

        public ActionResult KullanıcıEnvanter()
        {
            var envanterValues = envanterManager.GetList();
            return View(envanterValues);
        }

        public ActionResult KullancıOnemliMekanlar()
        {
            var OnemliMekanlarValues = onemliMekanlarManager.GetAll();
            return View(OnemliMekanlarValues);
        }

        public ActionResult KullanıcıHizmetler()
        {
            var HizmetlerValues = hm.GetList();
            return View(HizmetlerValues);
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}