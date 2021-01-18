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
            DAL.StarDB DC = new DAL.StarDB();
            StarDev.Models.Courses _m = new Models.Courses();
            var q = (from A in DC.Courses
                     where
                     (!string.IsNullOrEmpty(name) ? A.Title.Contains(name) || A.content.Contains(name) : true)
                     select A).ToList();

            _m.GetAllCourse = q;

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