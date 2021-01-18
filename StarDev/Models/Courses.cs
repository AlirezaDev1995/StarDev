using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarDev.Models
{
    public class Courses
    {

        public List<DAL.Courses> GetAllCourse { get; set; }

        public List<DAL.ViewCourse> ShowCourse { get; set; }
    }
}