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
    public class OnemliMekanlarController : Controller
    {
        // GET: OnemliMekanlar
        OnemliMekanlarManager onemliMekanlarManager = new OnemliMekanlarManager(new EfOnemliMekanlarDal());
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetList()
        {
            var OnemliMekanlarValues = onemliMekanlarManager.GetAll();
            return View(OnemliMekanlarValues);
        }
        
            [HttpGet]
            public ActionResult AddOnemliMekanlar()
            {
                return View();
            }

            [HttpPost]
            public ActionResult AddOnemliMekanlar(OnemliMekanlar entity)
            {
                OnemliMekanlarValidator onemlimekanlarValidator = new OnemliMekanlarValidator();
                ValidationResult results = onemlimekanlarValidator.Validate(entity);
                if (results.IsValid)
                {
                onemliMekanlarManager.AddOnemliMekanlar(entity);
                    return RedirectToAction("GetList");
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
        }
    }
