using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProje.Models.Sinifler;

namespace TravelTripProje.Controllers
{
    public class GirisController : Controller
    {
        // GET: Giris
        //public ActionResult Index()
        //{
        //    return View();
        //}
        Context c = new Context();
        public ActionResult Login ()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login (Admin ad)
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.Kullanici == ad.Kullanici && x.Sifre == ad.Sifre);
            if ( bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Kullanici, false);
                Session["Kullanici"] = bilgiler.Kullanici.ToString();
                return RedirectToAction("Index","Admin");
            }
            else 
            { 
                return View(); 
            }
        }
        public ActionResult LogOut ()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login","Giris");
        }
    }
}