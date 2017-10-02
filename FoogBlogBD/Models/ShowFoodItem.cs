using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoogBlogBD.Models
{
    public class ShowFoodItem
    {
        public int itemID { get; set; }
        public string itemName { get; set; }
        public int restaurantID { get; set; }
        public string restaurantName { get; set; }
        public int itemPrice { get; set; }
        public string itemSection { get; set; }
        public string itemPicture { get; set; }
        public double restaurantRating { get; set; }

        public int categoryID { get; set; }
        public string categoryName { get; set; }

        public int sectionID { get; set; }
        public string sectionName { get; set; }
    }
}