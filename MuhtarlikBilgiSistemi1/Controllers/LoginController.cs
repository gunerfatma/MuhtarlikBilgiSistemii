using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MuhtarlikBilgiSistemi1.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
       
        MuhtarManager mm = new MuhtarManager(new EfMuhtarDal());
        MuhtarLoginManager mlm = new MuhtarLoginManager(new EfMuhtarDal());
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin entity)
        {
            Context c = new Context();
            var adminUserInfo = c.Admins.FirstOrDefault(x => x.KullanıcıAdi == entity.KullanıcıAdi && x.Password == entity.Password);
            if (adminUserInfo != null)
            {
                FormsAuthentication.SetAuthCookie(adminUserInfo.KullanıcıAdi, false);
                Session["AdminUserName"] = adminUserInfo.KullanıcıAdi;
                return RedirectToAction("Index", "AdminMuhtar");
            }
            else
            {
                return RedirectToAction("Index");
            }

            
        }
        [HttpGet]
        public ActionResult MuhtarLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MuhtarLogin(Muhtar entity)
        {
            
            var muhtarUserInfo = mlm.GetMuhtar(entity.Eposta, entity.Sifre);
            if (muhtarUserInfo != null)
            {
                FormsAuthentication.SetAuthCookie(muhtarUserInfo.Eposta, false);
                Session["Eposta"] = muhtarUserInfo.Eposta;
                return RedirectToAction("Index", "MuhtarMahalle");
            }
            
            else
            {
                return RedirectToAction("MuhtarLogin");
            }

        }
        public ActionResult LoginOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction( "KulanıcıMahalle", "Kullanıcı");
        }
    }
}