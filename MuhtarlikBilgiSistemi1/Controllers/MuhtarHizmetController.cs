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
    public class MuhtarHizmetController : Controller
    {
        // GET: MuhtarHizmet
        HizmetlerManager hm = new HizmetlerManager(new EfHizmetlerDal());
        HizmetlerValidator hizmetlervalidator = new HizmetlerValidator();
       
        // GET: Hizmetler
        public ActionResult Index()
        {
            var HizmetlerValues = hm.GetListHizmet();
            return View(HizmetlerValues);
        }

        [HttpGet]
        public ActionResult AddHizmetler1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddHizmetler1(Hizmetler entity)
        {
            HizmetlerValidator hizmetlervalidator = new HizmetlerValidator();
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

        //*** MUHTAR GÜNCELLEME***

        [HttpGet]
        public ActionResult UpdateHizmetler1(int id)
        {
            var HizmetlerValues = hm.GetByIdHizmet(id);
            return View(HizmetlerValues);
        }

        [HttpPost]
        public ActionResult UpdateHizmetler1(Hizmetler entity)
        {
            hm.HizmetlerUpdate(entity);
            return RedirectToAction("Index");
        }





    }
}