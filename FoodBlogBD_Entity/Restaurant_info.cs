using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodBlogBD_Entity
{
    public class Restaurant_info
    {   
        [Key]
        public int Id { get; set; }
        public string restaurantName { get; set; }
        public string restaurantDetails { get; set; }
        public string restaurantLogo { get; set; }
        public string ContactNumber { get; set; }
        public string Website { get; set; }
        public int totalRating { get; set; }
        public int ratingGivenUser { get; set; }
        public double avarageRating { get; set; }
        
        public virtual List<restaurant_Branch> restaurant_Branch { get; set; }

        //public virtual Restaurant_Rating Restaurant_Rating { get; set; }
        //public virtual List<restaurantItem> restaurantItem { get; set; }
        //[ForeignKey("itemCategory")]
        //public List<Item_Category> Item_Category { get; set; }

    }
}
