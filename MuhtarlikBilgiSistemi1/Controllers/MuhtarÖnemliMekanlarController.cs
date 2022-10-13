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
    public class MuhtarÖnemliMekanlarController : Controller
    {
        // GET: MuhtarÖnemliMekanlar
        OnemliMekanlarManager onemliMekanlarManager = new OnemliMekanlarManager(new EfOnemliMekanlarDal());
        MahalleManager mahalleManager = new MahalleManager(new EfMahalleDal());
        

        public ActionResult Index()
        {
            
            var OnemliMekanlarValues = onemliMekanlarManager.GetListOnemliMekanlar();
            return View(OnemliMekanlarValues);
        }

        [HttpGet]
        public ActionResult AddOnemliMekanlar1()
        {
            //var OnemliMekanlarValues = onemliMekanlarManager.GetById(id);
            return View();

        }

        [HttpPost]
        public ActionResult AddOnemliMekanlar1(OnemliMekanlar onemliMekanlar)
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

        [HttpGet]
         public ActionResult UpdateOnemliMekanlar1(int id)
        {
            var OnemliMekanlarValues = onemliMekanlarManager.GetByIdOnemliMekanlar(id);
            return View(OnemliMekanlarValues);
        }

        [HttpPost]
        public ActionResult UpdateOnemliMekanlar1(OnemliMekanlar onemliMekanlar)
        {
            onemliMekanlarManager.UpdateOnemliMekanlar(onemliMekanlar);
            return RedirectToAction("Index");
        }
    }

}
