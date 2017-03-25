using MVC2503_New.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC2503_New.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Mesaj 1"] = "Bu bir Viewdata 1 mesajıdır";
            ViewData["Mesaj 2"] = "Bu bir Viewdata 2 mesajıdır";
            ViewBag.Mesaj = "Bu bir ViewBag Mesajıdır.";
            ViewBag.Bilgeadam = "Bilge Kadın";

            TempData["metin"]= "Index Actiondan Geliyorum :)";
            //return View();
            return RedirectToAction("index2");
        }
        public ActionResult index2()
        {
            return View();
        }
        public ActionResult index3()
        {
            List<Users> kullaniciListesi = new List<Users>();
            kullaniciListesi.AddRange(new List<Users> { new Users() { adi="Yavuz",soyadi="Gedik"}, new Users() { adi = "Seçkin", soyadi = "Umur" }, new Users() { adi = "Özgür", soyadi = "Saymaz" } });
            ViewBag.kullanicilar = kullaniciListesi;

            return View();
        }
    }
}