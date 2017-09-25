using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoogBlogBD.Models
{
    public class AllEntityModel
    {
        public IEnumerable<Item_Category> categoryList { get; set; }
        public IEnumerable<Restaurant_Rating> restaurantRatingList { get; set; }

    }
}