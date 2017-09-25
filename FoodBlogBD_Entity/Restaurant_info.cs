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
        public string restaurantName { get; set; }
        [Required]
        public int restaurantLocation { get; set; }
        [Required]
        public int restaurantDetails { get; set; }
        [Required]
        public string restaurantLogo { get; set; }
        //[Required]
        //public string  restaurantArea { get; set; }
        [Required]
        //[RegularExpression(@"^[0-9]*$", ErrorMessage = "Only Numubers are allowed.")]
        [RegularExpression(@"(^[+]{1}[8]{2}[01]{1}[0-9]{9}|^[8]{2}[01]{1}[0-9]{9}|^[01]{2}[0-9]{9})$", ErrorMessage = "Mobile Pattern for Bangladesh is not Correct.")]
        public string ContactNumber { get; set; }
        [Required]
        public string otherInfo { get; set; }

        //public virtual Restaurant_Rating Restaurant_Rating { get; set; }
        public virtual List<restaurantItem> restaurantItem { get; set; }
        public virtual List<restaurant_Branch> restaurant_Branch { get; set; }

        //[ForeignKey("itemCategory")]
        //public List<Item_Category> Item_Category { get; set; }

    }
}
