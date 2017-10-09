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
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        iItem_Category_Service category = Service_Center.GetItem_Category_Service();
        iRestaurant_info_Service restInfo = Service_Center.GetRestaurant_info_Service();

        public ActionResult Index()
        {
            HomePageModel hpModel = new HomePageModel();

            hpModel.Category = category.GetAllValues();
            hpModel.info = restInfo.GetAllValues();

            ViewBag.userName = Session["UserName"];
            ViewBag.logged = Session["loggedOn"];

            return View(hpModel);
        }

    }
}
