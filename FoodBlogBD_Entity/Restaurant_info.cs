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
        [Required]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "Only Characters are allowed.")]
        [Index(IsUnique = true)]
        public string restaurantName { get; set; }
        [Required]
        public int restaurantLocation { get; set; }
        [Required]
        public int restaurantDetails { get; set; }
        [Required]
        public string restaurantLogo { get; set; }
        [Required]
        //public int itemCategory { get; set; }

        public virtual Restaurant_Rating Restaurant_Rating { get; set; }
        public virtual List<restaurantItem> restaurantItem { get; set; }
        public virtual List<restaurant_Branch> restaurant_Branch { get; set; }

        //[ForeignKey("itemCategory")]
        //public List<Item_Category> Item_Category { get; set; }

    }
}
