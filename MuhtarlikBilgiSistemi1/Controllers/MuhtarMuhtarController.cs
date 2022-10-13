using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
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
    public class MuhtarMuhtarController : Controller
    {
        // GET: MuhtarMuhtar
        MuhtarManager mm = new MuhtarManager(new EfMuhtarDal());
        MuhtarValidator muhtarvalidator = new MuhtarValidator();

        // Context c = new Context();
       

        public ActionResult Index()
        {
            var MuhtarValues = mm.GetListMuhtar();
            return View(MuhtarValues);
        }

        //GÜNCELLEME

        [HttpGet]
        public ActionResult MuhtarUpdate1(int id)
        {

            var muhtarvalue = mm.GetByIdMuhtar(id);
            return View(muhtarvalue);


        }

        [HttpPost]
        public ActionResult MuhtarUpdate1(Muhtar entity)
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

   

