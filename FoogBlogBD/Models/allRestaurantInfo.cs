using FoodBlogBD_Entity;
using FoogBlogBD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoogBlogBD.Models
{
    public class allRestaurantInfo
    {
        public IEnumerable<Restaurant_info> restaurants { get; set; }
        public IEnumerable<restaurantItem> foodItems { get; set; }
        public IEnumerable<restaurant_Branch> branches { get; set; }
        public IEnumerable<Restaurant_Post>  posts { get; set; }
        public IEnumerable<Restaurant_FoodCategory> foodCategory { get; set; }
        public IEnumerable<RestaurantReviewFullModel> reviews { get; set; }


        public IEnumerable<Item_Category> categoryList { get; set; }

        public IEnumerable<Area_Info> areaList { get; set; }
    }
}