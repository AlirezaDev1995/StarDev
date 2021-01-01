using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StarDev.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HtmlCourse()
        {
            return View();
        }
        public ActionResult BootstrapCourse()
        {
            return View();
        }
        public ActionResult CssCourse()
        {
            return View();
        }
        public ActionResult JavaCourse()
        {
            return View();
        }
        public ActionResult PaythonCourse()
        {
            return View();
        }
    }
}