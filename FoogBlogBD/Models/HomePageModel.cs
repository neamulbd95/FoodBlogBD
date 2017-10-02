using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoogBlogBD.Models
{
    public class HomePageModel
    {
        public IEnumerable<Item_Category> Category { get; set; }
        public IEnumerable<Restaurant_info> info { get; set; }


    }
}