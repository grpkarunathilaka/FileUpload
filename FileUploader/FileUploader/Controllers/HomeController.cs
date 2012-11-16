using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FileUploader.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Test with ASP.NET MVC!";
            return View();
        }

        public ActionResult Delete()
        {
            ViewBag.Message = "Test with ASP.NET MVC!";
            return View("About");
        }

        public string Upload(HttpPostedFileBase fileData)
        {
            var fileName = this.Server.MapPath("~/uploads/" + System.IO.Path.GetFileName(fileData.FileName));
            fileData.SaveAs(fileName);

            return "ok";
        }

    }
}
