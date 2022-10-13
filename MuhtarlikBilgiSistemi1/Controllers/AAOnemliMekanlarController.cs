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

    public class AAOnemliMekanlarController : Controller
    {
        OnemliMekanlarManager onemliMekanlarManager = new OnemliMekanlarManager(new EfOnemliMekanlarDal());
        MahalleManager mahalleManager = new MahalleManager(new EfMahalleDal());
        //[Authorize]
        public ActionResult Index()
        {
            var OnemliMekanlarValues = onemliMekanlarManager.GetAll();
            return View(OnemliMekanlarValues);
        }



        [HttpGet]
        public ActionResult AddOnemliMekanlar(/*int id*/)
        {
            //ViewBag.d = id;
            //var OnemliMekanlarValues = onemliMekanlarManager.GetById(id);
            return View();
           
        }

        [HttpPost]
        public ActionResult AddOnemliMekanlar(OnemliMekanlar onemliMekanlar)
        {
            OnemliMekanlarValidator rules = new OnemliMekanlarValidator();
            ValidationResult result = rules.Validate(onemliMekanlar);
            if (result.IsValid)
            {
                onemliMekanlarManager.AddOnemliMekanlar(onemliMekanlar);
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




        //[HttpGet]
        //public ActionResult DeleteOnemliMekanlar()
        //{
           
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult DeleteOnemliMekanlar(OnemliMekanlar onemliMekanlar)
        //{
        //    onemliMekanlarManager.DeleteOnemliMekanlar(onemliMekanlar);
        //    return RedirectToAction("Index");
        //}

        public ActionResult DeleteOnemliMekanlar(int id)
        {
            var OnemliMekanlarValues = onemliMekanlarManager.GetById(id);
            onemliMekanlarManager.DeleteOnemliMekanlar(OnemliMekanlarValues);
            return RedirectToAction("Index");
        }



        [HttpGet]
       
        public ActionResult UpdateOnemliMekanlar(int id)
        {
            var OnemliMekanlarValues = onemliMekanlarManager.GetById(id);
            return View(OnemliMekanlarValues);
        }

        [HttpPost]
        public ActionResult UpdateOnemliMekanlar(OnemliMekanlar onemliMekanlar)
        {
            onemliMekanlarManager.UpdateOnemliMekanlar(onemliMekanlar);
            return RedirectToAction("Index");
        }
    }
}

 