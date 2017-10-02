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
    public class RestaurantController : Controller
    {
        //
        // GET: /Restaurant/
        iItem_Category_Service categoryList = Service_Center.GetItem_Category_Service();
        iArea_Info_Service areafullList = Service_Center.GetArea_Info_Service();

        iRestaurant_info_Service restaurants = Service_Center.GetRestaurant_info_Service();
        iRestaurant_Post_Service restaurantPosts = Service_Center.GetRestaurant_Post_Service();
        irestaurant_Branch_Service restaurantBranch = Service_Center.GetRestaurant_Branch_Service();
        irestaurantItems_Service restaurantItems = Service_Center.GetRestaurantItem_Service();
        iRestaurant_FoodCategory_Service restaurantCategory = Service_Center.GetRestaurant_FoodCategory_Service();

        public ActionResult Index(int Id)
        {
            ViewBag.restID = Id;
            ViewBag.restName = restaurants.GetSingle(Id).restaurantName;
            ViewBag.restLogo = Url.Content(restaurants.GetSingle(Id).restaurantLogo);
            ViewBag.details = restaurants.GetSingle(Id).restaurantDetails;
            ViewBag.restContactNumber = restaurants.GetSingle(Id).ContactNumber;
            ViewBag.restRating = restaurants.GetSingle(Id).avarageRating;
            ViewBag.restWebsite = restaurants.GetSingle(Id).Website;

            allRestaurantInfo restaurantInfo = new allRestaurantInfo();

            restaurantInfo.foodItems = restaurantItems.GetByRestaurant(Id);
            restaurantInfo.foodCategory = restaurantCategory.GetByRestaurant(Id);
            restaurantInfo.branches = restaurantBranch.GetByRestaurant(Id);
            restaurantInfo.posts = restaurantPosts.GetByRestaurant(Id);

            restaurantInfo.categoryList = categoryList.GetAllValues();

            return View(restaurantInfo);
        }

        public ActionResult ShowAllRestaurants(int? page)
        {
            allRestaurantInfo rest = new allRestaurantInfo();
            rest.restaurants = restaurants.GetAllValues();
            rest.categoryList = categoryList.GetAllValues();
            rest.areaList = areafullList.GetAllValues();

            return View(rest);
        }

        public  ActionResult showRestaurantByfoodCategory(int Id)
        {

            IEnumerable<Restaurant_FoodCategory> restfoodList= restaurantCategory.GetByCategory(Id);
            IEnumerable<Item_Category> catelist = categoryList.GetAllValues();
            IEnumerable<Area_Info> arealist = areafullList.GetAllValues();

            List<RestaurantsFoodCategory> restFoodCategoryList = new List<RestaurantsFoodCategory>();

            foreach(Item_Category cat in catelist)
            {
                RestaurantsFoodCategory restFood = new RestaurantsFoodCategory();
                restFood.categoryID = cat.Id;
                restFood.categoryName = cat.categoryName;

                restFoodCategoryList.Add(restFood);
            }

            foreach(Area_Info area in arealist)
            {
                RestaurantsFoodCategory restFood = new RestaurantsFoodCategory();
                restFood.areaID = area.Id;
                restFood.areaName = area.AreaName;

                restFoodCategoryList.Add(restFood);
            }

            foreach(Restaurant_FoodCategory rf in restfoodList)
            {
                RestaurantsFoodCategory restFood = new RestaurantsFoodCategory();

                restFood.Id = rf.restaurantID;
                restFood.restName = restaurants.GetSingle(rf.restaurantID).restaurantName;
                restFood.restLogo = restaurants.GetSingle(rf.restaurantID).restaurantLogo;
                restFood.restWebsite = restaurants.GetSingle(rf.restaurantID).Website;
                restFood.restContact = restaurants.GetSingle(rf.restaurantID).ContactNumber;
                restFood.restRating = restaurants.GetSingle(rf.restaurantID).avarageRating;

                restFoodCategoryList.Add(restFood);
            }

            return View(restFoodCategoryList);
        }

        public ActionResult showRestaurantByArea(int Id)
        {
            string areaname = areafullList.GetSingle(Id).AreaName;

            allRestaurantInfo rest = new allRestaurantInfo();
            rest.branches = restaurantBranch.GetByLocation(areaname);
            rest.categoryList = categoryList.GetAllValues();
            rest.areaList = areafullList.GetAllValues();

            //ViewBag.areaName = areaname;

            return View(rest);
        }
        [HttpPost]
        public  ActionResult updateRating()
        {
            if (Request.Form["rate"] != null)
            {
                int id = Convert.ToInt32(Request.Form["restaurant"]);
                int givenRating = Convert.ToInt32(Request.Form["rateRest"]);

                int totalRating = restaurants.GetSingle(id).totalRating;
                int givenUser = restaurants.GetSingle(id).ratingGivenUser;

                totalRating += givenRating;
                givenUser += 1;

                double averageRate = totalRating / givenUser;

                Restaurant_info restInfo = new Restaurant_info();

                restInfo.Id = id;
                restInfo.totalRating = totalRating;
                restInfo.ratingGivenUser = givenUser;
                restInfo.avarageRating = averageRate;

                restaurants.UpdateRating(restInfo);

                return RedirectToAction("Index", new { Id = id });
            }

            else
            {
                return View("Index", "Home");
            }
        }
    }
}
