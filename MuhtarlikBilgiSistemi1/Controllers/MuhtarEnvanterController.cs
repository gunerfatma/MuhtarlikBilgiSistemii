using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuhtarlikBilgiSistemi1.Controllers
{
    public class MuhtarEnvanterController : Controller
    {
        // GET: MuhtarEnvanter
        EnvanterManager envanterManager = new EnvanterManager(new EfEnvanterDal());
        Context c = new Context();
        

        public ActionResult Index(/*string p*/)
        {
            //p = (string)Session["Eposta"];
            //var muhtarIdInfo = c.Muhtars.Where(x => x.Eposta == p).Select(x => x.MuhtarId).FirstOrDefault();
            //var envanterValues = envanterManager.GetAllByMuhtar(muhtarIdInfo);
            //return View(envanterValues);

            var envanterValues = envanterManager.GetListEnvanter();
            return View(envanterValues);
        }

        //güncelleme

        [HttpGet]
        public ActionResult UpdateEnvanter1(int id)
        {
            var envanterValues = envanterManager.GetByIdEnvanter(id);
            return View(envanterValues);
        }

        [HttpPost]
        public ActionResult UpdateEnvanter1(Envanter entity)
        {
            envanterManager.UpdateEnvanter(entity);
            return RedirectToAction("Index");
        }

    }
}