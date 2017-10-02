using FoodBlogBD_Entity;
using FoodBlogBD_ServiceLayer;
using FoogBlogBD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoogBlogBD.Controllers
{
    public class testController : Controller
    {
        //
        // GET: /test/
        iItem_Category_Service cat = Service_Center.GetItem_Category_Service();
        iRestaurant_info_Service restInfo = Service_Center.GetRestaurant_info_Service();

        public ActionResult Index()
        {
            return View();
        }

    }
}
