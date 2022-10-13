using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Migrations;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuhtarlikBilgiSistemi1.Controllers
{
    public class AdminMuhtarController : Controller
    {

        MuhtarManager mm = new MuhtarManager(new EfMuhtarDal());
        MuhtarValidator muhtarvalidator = new MuhtarValidator();
        Context c = new Context();
        //[Authorize(Roles = "A")]
        public ActionResult Index(/*int id=0*/)
        {
            var MuhtarValues = mm.GetList();
            return View(MuhtarValues);
            //string p = (string)Session["Eposta"];
            //var muhtarValues = c.Muhtars.Where(x => x.Eposta == p).Select(x => x.MuhtarId).FirstOrDefault();
            //var muhtarValues = mm.GetById(id);
            //return View(muhtarValues);


        }

        [HttpGet]
        public ActionResult AddMuhtar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddMuhtar(Muhtar entity)
        {
            //MuhtarValidator muhtarvalidator = new MuhtarValidator();
            ValidationResult result = muhtarvalidator.Validate(entity);
            if (result.IsValid)
            {
                mm.MuhtarAdd(entity);
                return RedirectToAction("Index");

            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }


        public ActionResult DeleteMuhtar(int id)
        {
            var AdminMuhtarValues = mm.GetById(id);
            mm.MuhtarDelete(AdminMuhtarValues);
            return RedirectToAction("Index");
        }



        [HttpGet]
        public ActionResult MuhtarUpdate(int id)
        {


            var muhtarvalue = mm.GetById(id);
            return View(muhtarvalue);


            }

        [HttpPost]
        public ActionResult MuhtarUpdate(Muhtar entity)
        {
            ValidationResult result = muhtarvalidator.Validate(entity);
            if (result.IsValid)
            {
                
                mm.MuhtarUpdate(entity);
                return RedirectToAction("Index");

            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }
    }
}
