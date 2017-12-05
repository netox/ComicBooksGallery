using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBooksGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        /*public string Detail()
        {
            return "message from the controller";
        }*/

        /*public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Wednesday)
            {
                return new RedirectResult("/");
            }
            return new ContentResult() { Content = "message from the controller" };
        }*/

        /*public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)

                return Redirect("/");
            
            return Content("message from the controller");
        }*/

        public ActionResult Detail()
        {
            return View();
        }
    }
}