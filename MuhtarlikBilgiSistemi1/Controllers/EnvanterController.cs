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
    public class EnvanterController : Controller
       
    {
        EnvanterManager envanterManager = new EnvanterManager(new EfEnvanterDal());
        EnvanterValidator envanterValidator = new EnvanterValidator();
       // [Authorize]
        public ActionResult Index()
        {
            var envanterValues = envanterManager.GetList();
            return View(envanterValues);
        }
        

        [HttpGet]
        public ActionResult AddEnvanter()
        {
            //ViewBag.d = id;
            return View();
        }

        [HttpPost]
        public ActionResult AddEnvanter(Envanter envanter)
        {
            //EnvanterValidator rules = new EnvanterValidator();
            ValidationResult result = envanterValidator.Validate(envanter);
            if (result.IsValid)
            {
                envanterManager.AddEnvanter(envanter);
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


        public ActionResult DeleteEnvanter(int id)
        {
            var envanterValue = envanterManager.GetById(id);
            envanterManager.DeleteEnvanter(envanterValue);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateEnvanter(int id)
        {
            var envanterValues = envanterManager.GetById(id);
            return View(envanterValues);
        }

        [HttpPost]
        public ActionResult UpdateEnvanter(Envanter entity)
        {
            envanterManager.UpdateEnvanter(entity);
            return RedirectToAction("Index");
        }

        
    }
}
    
