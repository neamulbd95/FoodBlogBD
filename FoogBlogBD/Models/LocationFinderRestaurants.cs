using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoogBlogBD.Models
{
    public class LocationFinderRestaurants
    {
        public int branchID { get; set; }
        public string branchName { get; set; }
        public string restaurantLOGO { get; set; }
        public int restaurantID { get; set; }
        public string branchArea { get; set; }
        public string branchAddress { get; set; }
        public string branchOpenHour { get; set; }
        public string branchCloseHour { get; set; }
        public string branchPhoneNumber { get; set; }
        public double branchLati { get; set; }
        public double branchLongi { get; set; }
    }
}