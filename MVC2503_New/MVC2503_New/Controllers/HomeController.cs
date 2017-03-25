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
            return View();
        }
    }
}