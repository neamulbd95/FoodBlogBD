using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoogBlogBD.Controllers
{
    public class foodCategoryController : Controller
    {
        //
        // GET: /foodCategory/

        public ActionResult Index(int Id)
        {
            return View();
        }
    }
}
