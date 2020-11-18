using gorodnitsevAutocompliterProj2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gorodnitsevAutocompliterProj2.Controllers
{
    public class HomeController : Controller
    {
        Entities db = new Entities(); 
        public ActionResult Index(string searching)
        {
            return View(db.NameInfoes.Where(x=>x.Emakeelnenimi.Contains(searching) || searching == null).ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}