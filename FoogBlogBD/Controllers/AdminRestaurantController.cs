using FoodBlogBD_Entity;
using FoodBlogBD_ServiceLayer;
using FoogBlogBD.Models;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoogBlogBD.Controllers
{
    public class AdminRestaurantController : Controller
    {
        //
        // GET: /AdminRestaurant/
        iRestaurant_info_Service restaurants = Service_Center.GetRestaurant_info_Service();
        irestaurant_Branch_Service branches = Service_Center.GetRestaurant_Branch_Service();
        irestaurantItems_Service items = Service_Center.GetRestaurantItem_Service();

        public ActionResult Index()
        {
            if (Session["UserName"].ToString() == "admin")
            {
                return View(restaurants.GetAllValues());
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult showBranches(int Id)
        {
            if (Session["UserName"].ToString() == "admin")
            {
                IEnumerable<restaurant_Branch> branchlist = branches.GetByRestaurant(Id);

                ViewBag.id = Id;
                ViewBag.name = restaurants.GetSingle(Id).restaurantName;
                ViewBag.pic = restaurants.GetSingle(Id).restaurantLogo;

                return View(branchlist);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult addRestRequest()
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

        [HttpPost]
        public ActionResult AddRest(HttpPostedFileBase Picture)
        {
            if (Session["UserName"].ToString() == "admin")
            {
                if (Request.Form["restAddBtn"] != null)
                {
                    if (Picture != null && Picture.ContentLength > 0)
                    {
                        Restaurant_info rest = new Restaurant_info();

                        var filename = Path.GetFileName(Picture.FileName);
                        var path = Path.Combine(Server.MapPath("~/images"), filename);
                        Picture.SaveAs(path);

                        rest.restaurantName = Request.Form["restName"];
                        rest.restaurantDetails = Request.Form["detail"];
                        rest.ContactNumber = Request.Form["contactName"];
                        rest.restaurantLogo = "~/images/" + filename.ToString();
                        rest.Website = Request.Form["webName"];

                        restaurants.Insert(rest);

                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return RedirectToAction("Index", "Admin");
                    }
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

        public ActionResult Delete(int Id)
        {

            if (Session["UserName"].ToString() == "admin")
            {
                items.DeleteByRestaurant(Id);
                branches.DeleteByRestaurant(Id);
                restaurants.Delete(Id);

                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

           
        }
    }
}
