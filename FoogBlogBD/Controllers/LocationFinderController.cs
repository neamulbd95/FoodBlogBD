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
    public class LocationFinderController : Controller
    {
        //
        // GET: /LocationFinder/
        iItem_Category_Service categrories = Service_Center.GetItem_Category_Service();
        iRestaurant_info_Service rastuarants = Service_Center.GetRestaurant_info_Service();
        iRestaurant_Coordinate_Service restCoOrdinate = Service_Center.GetRestaurant_Coordinate_Service();
        irestaurant_Branch_Service branches = Service_Center.GetRestaurant_Branch_Service();
        public ActionResult Index()
        {
            allRestaurantInfo restaurants = new allRestaurantInfo();
            restaurants.categoryList = categrories.GetAllValues();

            return View(restaurants);
        }

        public ActionResult MyCoordinate()
        {
            if (Request.Form["submitBtn"] != null) 
            {
                double lati = Convert.ToDouble(Request.Form["latitudeName"]);
                double longi = Convert.ToDouble(Request.Form["longitudeName"]);

                IEnumerable<Restaurant_Coordinate> RangeRestaurantsList = restCoOrdinate.GetRange(lati, longi);

                List<LocationFinderRestaurants> RangeRestList = new List<LocationFinderRestaurants>();

                foreach(Restaurant_Coordinate rr in RangeRestaurantsList)
                {
                    LocationFinderRestaurants rangeRest = new LocationFinderRestaurants();

                    rangeRest.branchID = rr.restId;
                    rangeRest.branchName = branches.GetSingle(rr.restId).branchName;
                    rangeRest.restaurantLOGO = rastuarants.GetSingle(branches.GetSingle(rr.restId).restaurantID).restaurantLogo;
                    rangeRest.branchArea = branches.GetSingle(rr.restId).branchArea;
                    rangeRest.branchAddress = branches.GetSingle(rr.restId).branchAddress;
                    rangeRest.branchPhoneNumber = branches.GetSingle(rr.restId).branchPhoneNumber;
                    rangeRest.restaurantID = branches.GetSingle(rr.restId).restaurantID;
                    rangeRest.branchOpenHour = branches.GetSingle(rr.restId).branchOpenHour;
                    rangeRest.branchCloseHour = branches.GetSingle(rr.restId).branchCloseHour;
                    rangeRest.branchLati = rr.latitude;
                    rangeRest.branchLongi = rr.longitude;

                    RangeRestList.Add(rangeRest);
                }

                return View(RangeRestList);
            }
            else
            {
                return View("Index","Home");
            }
        }
    }
}
