using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StarDev.Controllers
{
    public class CouresController : Controller
    {
        // GET: Coures
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Courses(int page=1)
        {
            DAL.StarDB DC = new DAL.StarDB();
            StarDev.Models.Courses _m = new Models.Courses();
            int TotalCount = DC.Courses.Count();
            int PageItem =6;
            int skip = (page - 1) * PageItem;
            ViewBag.pageId = page;
            ViewBag.pageCount = (TotalCount / PageItem);
            if (TotalCount % PageItem != 0)
            {
                ViewBag.PageCount = (TotalCount / PageItem) + 1;
            }
            _m.GetAllCourse = DC.Courses.OrderBy(x => x.CourseID).Skip(skip).Take(PageItem).ToList();
            return View(_m);
        }




        public ActionResult ViewCourse(int? id)
        {
            DAL.StarDB DC = new DAL.StarDB();
            StarDev.Models.Courses _m = new Models.Courses();
            _m.ShowCourse = DC.ViewCourse.Where(x => x.ShowCourseID == id).ToList();
            return View(_m);
        }
    }
}
