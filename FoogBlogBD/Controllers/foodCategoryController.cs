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
    public class foodCategoryController : Controller
    {
        //
        // GET: /foodCategory/
        iItem_Category_Service category = Service_Center.GetItem_Category_Service();
        iItem_Section_Service section = Service_Center.GetItem_Section_Service();
        irestaurantItems_Service foodItems = Service_Center.GetRestaurantItem_Service();
        iRestaurant_info_Service restaurantInfo = Service_Center.GetRestaurant_info_Service();

        public ActionResult Index(int Id)
        {
            IEnumerable<Item_Category> categoryList = category.GetAllValues();
            IEnumerable<restaurantItem> itemsList = foodItems.GetByCategory(Id);
            IEnumerable<Item_Section> sectionList = section.GetByCategory(Id);

            List<ShowFoodItem> selectItemList = new List<ShowFoodItem>();

            foreach(Item_Section sec in sectionList)
            {
                ShowFoodItem showItem = new ShowFoodItem();

                showItem.sectionID = sec.Id;
                showItem.sectionName = sec.sectionName;

                selectItemList.Add(showItem);
            }

            foreach (restaurantItem i in itemsList)
            {
                ShowFoodItem showItem = new ShowFoodItem();

                showItem.itemID = i.Id;
                showItem.itemName = i.itemName;
                showItem.itemPrice = i.itemPrice;
                showItem.itemPicture = i.itemPicture;
                showItem.itemSection = section.GetSingle(i.itemSection).sectionName;
                showItem.restaurantID = restaurantInfo.GetSingle(i.restaurantID).Id;
                showItem.restaurantName = restaurantInfo.GetSingle(i.restaurantID).restaurantName;
                showItem.restaurantRating = restaurantInfo.GetSingle(i.itemCategory).avarageRating;

                selectItemList.Add(showItem);
            }

            foreach (Item_Category c in categoryList)
            {
                ShowFoodItem cat = new ShowFoodItem();
                cat.categoryID = c.Id;
                cat.categoryName = c.categoryName;

                selectItemList.Add(cat);
            }

            ViewBag.categoryID = Id;
            ViewBag.CategoryName = category.GetSingle(Id).categoryName;
            return View(selectItemList);
        }

        public ActionResult priceFilter()
        {
            //ViewBag.prizerange = Request.Form["prizeRange"];
            if (Request.Form["priceRangeFilterBtn"] != null)
            {
                int maximum = Convert.ToInt32(Request.Form["prizeRange"]);
                int categoryID = Convert.ToInt32(Request.Form["categoryID"]);
                // foodItems.GetByPrice(categoryID, 0, maximum)

                IEnumerable<Item_Category> categoryList = category.GetAllValues();
                IEnumerable<restaurantItem> itemsList = foodItems.GetByPrice(categoryID, 0, maximum);
                IEnumerable<Item_Section> sectionList = section.GetByCategory(categoryID);

                List<ShowFoodItem> selectItemList = new List<ShowFoodItem>();

                foreach (Item_Section sec in sectionList)
                {
                    ShowFoodItem showItem = new ShowFoodItem();

                    showItem.sectionID = sec.Id;
                    showItem.sectionName = sec.sectionName;

                    selectItemList.Add(showItem);
                }


                foreach (restaurantItem i in itemsList)
                {
                    ShowFoodItem showItem = new ShowFoodItem();

                    showItem.itemID = i.Id;
                    showItem.itemName = i.itemName;
                    showItem.itemPrice = i.itemPrice;
                    showItem.itemPicture = i.itemPicture;
                    showItem.restaurantID = restaurantInfo.GetSingle(i.restaurantID).Id;
                    showItem.restaurantName = restaurantInfo.GetSingle(i.restaurantID).restaurantName;
                    showItem.restaurantRating = restaurantInfo.GetSingle(i.itemCategory).avarageRating;

                    selectItemList.Add(showItem);
                }

                foreach (Item_Category c in categoryList)
                {
                    ShowFoodItem cat = new ShowFoodItem();
                    cat.categoryID = c.Id;
                    cat.categoryName = c.categoryName;

                    selectItemList.Add(cat);
                }

                ViewBag.categoryID = categoryID;
                ViewBag.CategoryName = category.GetSingle(categoryID).categoryName;
                return View(selectItemList);
            }
            else
            {
                return View("Index","Home");
            }
            
        }

        public ActionResult foodItemBySection(int Id)
        {
            IEnumerable<Item_Category> categoryList = category.GetAllValues();
            IEnumerable<restaurantItem> itemsList = foodItems.GetBySection(Id);
            IEnumerable<Item_Section> sectionList = section.GetByCategory(section.GetSingle(Id).categoryID);

            List<ShowFoodItem> selectItemList = new List<ShowFoodItem>();

            foreach (Item_Section sec in sectionList)
            {
                ShowFoodItem showItem = new ShowFoodItem();

                showItem.sectionID = sec.Id;
                showItem.sectionName = sec.sectionName;

                selectItemList.Add(showItem);
            }

            foreach (restaurantItem i in itemsList)
            {
                ShowFoodItem showItem = new ShowFoodItem();

                showItem.itemID = i.Id;
                showItem.itemName = i.itemName;
                showItem.itemPrice = i.itemPrice;
                showItem.itemPicture = i.itemPicture;
                showItem.itemSection = section.GetSingle(i.itemSection).sectionName;
                showItem.restaurantID = restaurantInfo.GetSingle(i.restaurantID).Id;
                showItem.restaurantName = restaurantInfo.GetSingle(i.restaurantID).restaurantName;
                showItem.restaurantRating = restaurantInfo.GetSingle(i.itemCategory).avarageRating;

                selectItemList.Add(showItem);
            }

            foreach (Item_Category c in categoryList)
            {
                ShowFoodItem cat = new ShowFoodItem();
                cat.categoryID = c.Id;
                cat.categoryName = c.categoryName;

                selectItemList.Add(cat);
            }

            ViewBag.categoryID = section.GetSingle(Id).categoryID;
            ViewBag.CategoryName = category.GetSingle(section.GetSingle(Id).categoryID).categoryName;
            return View(selectItemList);
        }
    }
}

   
