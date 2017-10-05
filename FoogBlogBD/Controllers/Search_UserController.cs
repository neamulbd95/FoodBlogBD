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
    public class Search_UserController : Controller
    {
        //
        // GET: /Search_User/
        iItem_Category_Service category = Service_Center.GetItem_Category_Service();
        iItem_Section_Service section = Service_Center.GetItem_Section_Service();
        irestaurant_Branch_Service branch = Service_Center.GetRestaurant_Branch_Service();
        iRestaurant_info_Service restaurant = Service_Center.GetRestaurant_info_Service();
        irestaurantItems_Service foodItem = Service_Center.GetRestaurantItem_Service();

        public ActionResult Index()
        {
            if (Request.Form["serachBtn"] != null)
            {
                string searchKeyword = Request.Form["nameSearch"];

                IEnumerable<Restaurant_info> restInfoList = restaurant.searchRestaurants(searchKeyword);
                IEnumerable<restaurantItem> foodItemList = foodItem.searchItem(searchKeyword);

                List<ShowFoodItem> itemList = new List<ShowFoodItem>();

                foreach(restaurantItem food in foodItemList)
                {
                    ShowFoodItem item = new ShowFoodItem();

                    item.itemID = food.Id;
                    item.itemName = food.itemName;
                    item.restaurantID = food.restaurantID;
                    item.restaurantName = restaurant.GetSingle(food.restaurantID).restaurantName;
                    item.categoryID = food.itemCategory;
                    item.categoryName = category.GetSingle(food.itemCategory).categoryName;
                    item.sectionID = food.itemSection;
                    item.sectionName = section.GetSingle(food.itemSection).sectionName;
                    item.itemPicture = food.itemPicture;
                    item.itemPrice = food.itemPrice;

                    itemList.Add(item);
                }

                searchItemModel searchItem = new searchItemModel();
                searchItem.foodItemFullDetailsList = itemList;
                searchItem.restInfoList = restInfoList;
                searchItem.categoryList = category.GetAllValues();

                return View(searchItem);
            }
            else
            {
                return View("Index","Home");
            }
        }

    }
}
