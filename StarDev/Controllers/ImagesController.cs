using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace StarDev.Controllers
{
    public class ImagesController : Controller
    {
        // GET: Images
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult SaveImages(string Title,HttpPostedFileBase file)

        {

            DAL.StarDevEntities1 DC = new DAL.StarDevEntities1();
            System.Drawing.Image sourceimage = System.Drawing.Image.FromStream(file.InputStream);
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(sourceimage, typeof(byte[]));
            DAL.Image _img= new DAL.Image();
            _img.Title = Title;
            _img.File = xByte;
            DC.Image.Add(_img);
            DC.SaveChanges();
            return RedirectToAction("Index", "Images");
        }
        public async Task<ActionResult> RenderImage(int id)
        {
            DAL.StarDevEntities1 DC = new DAL.StarDevEntities1();
            DAL.Image item = await DC.Image.FindAsync(id);
            byte[] photoBack = item.File;
            return File(photoBack, "image/jpeg");
        }

        
    }
}