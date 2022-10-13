using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuhtarlikBilgiSistemi1.Controllers
{
    public class MahalleController : Controller
    {
        MahalleManager mahalleManager = new MahalleManager(new EfMahalleDal());
        MahalleValidator mahallevalidator = new MahalleValidator();
        //[Authorize]
        // GET: Mahalle
      
        public ActionResult Index()
        {
            var mahallevalues = mahalleManager.GetList();
            return View(mahallevalues);
        }

        [HttpGet]
        public ActionResult AddMahalle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddMahalle(Mahalle entity)
        {
            
            ValidationResult result = mahallevalidator.Validate(entity);
            if (result.IsValid)
            {
                mahalleManager.AddMahalle(entity);
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



        public ActionResult DeleteMahalle(int id)
        {
            var MahalleValues = mahalleManager.GetById(id);
            mahalleManager.DeleteMahalle(MahalleValues);
            return RedirectToAction("Index");
        }



        [HttpGet]
        public ActionResult MahalleUpdate(int id)
        {

            var mahallevalue = mahalleManager.GetById(id);
            return View(mahallevalue);


        }

        [HttpPost]
        public ActionResult MahalleUpdate(Mahalle entity)
        {
            ValidationResult result = mahallevalidator.Validate(entity);
            if (result.IsValid)
            {

                mahalleManager.UpdateMahalle(entity);
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
   