using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoogBlogBD.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            if (Session["UserName"].ToString() == "admin")
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            
        }

    }
}
