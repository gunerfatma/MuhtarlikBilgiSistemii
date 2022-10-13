using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuhtarlikBilgiSistemi1.Controllers
{
    public class HizmetlerController : Controller
    {
        HizmetlerManager hm = new HizmetlerManager(new EfHizmetlerDal());
        HizmetlerValidator hizmetlervalidator = new HizmetlerValidator();
        // GET: Hizmetler
        //[Authorize]
        public ActionResult Index()
        {
            var HizmetlerValues = hm.GetList();
            return View(HizmetlerValues);
        }

        //***EKLEME***

        [HttpGet]
        public ActionResult AddHizmetler()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddHizmetler(Hizmetler entity)
        {
            //HizmetlerValidator hizmetlervalidator = new HizmetlerValidator();
            ValidationResult results = hizmetlervalidator.Validate(entity);
            if (results.IsValid)
            {
                hm.HizmetlerAdd(entity);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public ActionResult DeleteHizmet(int id)
        {
            var HizmetValues = hm.GetById(id);
            hm.HizmetlerDelete(HizmetValues);
            return RedirectToAction("Index");
        }



        //*** MUHTAR GÜNCELLEME***

        [HttpGet]
        public ActionResult UpdateHizmetler(int id)
        {
            var HizmetlerValues = hm.GetById(id);
            return View(HizmetlerValues);
        }

        [HttpPost]
        public ActionResult UpdateHizmetler(Hizmetler entity)
        {
            hm.HizmetlerUpdate(entity);
            return RedirectToAction("Index");
        }



        

        ////[HttpGet]
        ////public ActionResult UpdateMuhtarHizmetler(int id)
        ////{
        ////    //return View();
        ////    var hizmetlervalue = hm.GetById(id);
        ////    return View(hizmetlervalue);
        ////}

        ////[HttpPost]
        ////public ActionResult UpdateMuhtarHizmetler(Hizmetler entity)
        ////{
        ////    ValidationResult result = hizmetlervalidator.Validate(entity);
        ////    if (result.IsValid)
        ////    {
        ////        hm.HizmetlerUpdate(entity);
        ////        return RedirectToAction("Index");
        ////    }
        ////    else
        ////    {
        ////        foreach (var item in result.Errors)
        ////        {
        ////            ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
        ////        }
        ////    }

        ////    return View();
        ////}

        ////**** BELEDİYE GÜNCELLEME**

        //[HttpGet]
        //public ActionResult UpdateBelediyeHizmetler(int id)
        //{
        //    var HizmetlerValues = hm.GetById(id);
        //    return View(HizmetlerValues);
        //}

        //[HttpPost]
        //public ActionResult UpdateBelediyeHizmetler(Hizmetler entity)
        //{
        //    hm.HizmetlerUpdate(entity);
        //    return RedirectToAction("Index");
        //}


        ////[HttpGet]
        ////public ActionResult UpdateBelediyeHizmetler()
        ////{
        ////    return View();
        ////    //var hizmetlervalue = hm.GetById(id);
        ////    //return View(hizmetlervalue);
        ////}

        ////[HttpPost]
        ////public ActionResult UpdateBelediyeHizmetler(Hizmetler entity)
        ////{
        ////    ValidationResult result = hizmetlervalidator.Validate(entity);
        ////    if (result.IsValid)
        ////    {
        ////        hm.HizmetlerUpdate(entity);
        ////        return RedirectToAction("Index");
        ////    }
        ////    else
        ////    {
        ////        foreach (var item in result.Errors)
        ////        {
        ////            ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
        ////        }
        ////    }

        ////    return View();
        ////}
    }
}

