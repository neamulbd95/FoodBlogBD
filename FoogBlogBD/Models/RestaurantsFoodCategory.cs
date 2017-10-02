using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoogBlogBD.Models
{
    public class RestaurantsFoodCategory
    {
        public int Id { get; set; }
        public string restName { get; set; }
        public string restLogo { get; set; }
        public string restWebsite { get; set; }
        public string restContact { get; set; }
        public double restRating { get; set; }

        public int categoryID { get; set; }
        public string categoryName { get; set; }

        public int areaID { get; set; }
        public string areaName { get; set; }
    }
}