using FoodBlogBD_Entity;
using FoodBlogBD_ServiceLayer;
using FoogBlogBD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;


namespace FoogBlogBD.Controllers
{
    public class AdminBranchController : Controller
    {
        //
        // GET: /AdminBranch/
        iArea_Info_Service areas = Service_Center.GetArea_Info_Service();
        iRestaurant_info_Service rests = Service_Center.GetRestaurant_info_Service();
        irestaurant_Branch_Service branchs = Service_Center.GetRestaurant_Branch_Service();
        irestaurantItems_Service items = Service_Center.GetRestaurantItem_Service();

        public ActionResult Index()
        {
            if (Session["UserName"].ToString() == "admin")
            {
                ViewBag.restID = Request.Form["resturantId"];
                ViewBag.restName = rests.GetSingle(Convert.ToInt32(Request.Form["resturantId"])).restaurantName;

                return View(areas.GetAllValues());
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
           
        }
        [HttpPost]
        public ActionResult AddBranch()
        {
            if (Session["UserName"].ToString() == "admin")
            {
                if (Request.Form["branchAddBtn"] != null)
                {
                    restaurant_Branch branch = new restaurant_Branch();

                    branch.branchName = Request.Form["restName"];
                    branch.branchAddress = Request.Form[""];
                    branch.branchArea = Request.Form["AreaName"];
                    branch.branchMap = Request.Form["mapName"];
                    branch.branchOpenHour = Request.Form["openName"];
                    branch.branchCloseHour = Request.Form["closeName"];
                    branch.restaurantID = Convert.ToInt32(Request.Form["restID"]);
                    branch.branchPhoneNumber = Request.Form["contactName"];

                    branchs.Insert(branch);

                    return RedirectToAction("showBranches", "AdminRestaurant", new { id = Convert.ToInt32(Request.Form["restID"]) });
                }
                else
                {
                    return RedirectToAction("Index", "Admin");
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            
        }

        public ActionResult showFoodItems(int Id)
        {
            if (Session["UserName"].ToString() == "admin")
            {
                return View(items.GetByCategory(branchs.GetSingle(Id).restaurantID));
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            
        }

        public ActionResult Delete(int Id)
        {
            if (Session["UserName"].ToString() == "admin")
            {
                branchs.Delete(Id);
                return RedirectToAction("Index", "AdminRestaurant");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            
        }
    }
}
