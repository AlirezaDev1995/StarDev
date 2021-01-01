using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StarDev.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()

        {
            return View();
        
        }
        public ActionResult NotFound()
        {
            return View();
        }
        public ActionResult Course(string name)
        {
            DAL.StarDevEntities1 DC = new DAL.StarDevEntities1();
            StarDev.Models.SearchContent _m = new Models.SearchContent();
            var q = (from A in DC.MainContent
                     where
                     (!string.IsNullOrEmpty(name) ? A.Title.Contains(name) || A.Content.Contains(name) : true)
                     select A).ToList();

            _m.GetAllContent = q;

            if (q.Count > 0)
            {

                return View(_m);
            }
            else
            {
                return RedirectToAction("NotFound", "Home");
            }
        }

    
    }
}