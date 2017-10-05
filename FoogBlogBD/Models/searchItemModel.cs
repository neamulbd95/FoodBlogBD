using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoogBlogBD.Models
{
    public class searchItemModel
    {
        public IEnumerable<Restaurant_info> restInfoList { get; set; }
        public IEnumerable<ShowFoodItem> foodItemFullDetailsList { get; set; }
        public IEnumerable<Item_Category> categoryList { get; set; }
    }
}