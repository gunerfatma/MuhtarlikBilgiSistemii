using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuhtarlikBilgiSistemi1.Controllers
{
    public class AOnemliMekanlarController : Controller
    {
        OnemliMekanlarManager onemliMekanlarManager = new OnemliMekanlarManager(new EfOnemliMekanlarDal());
        // GET: AOnemliMekanlar
        //[Authorize(Roles = "A")]
        public ActionResult Index()
        {
            var OnemliMekanlarValues = onemliMekanlarManager.GetAll();
            return View(OnemliMekanlarValues);
        }
    }
}