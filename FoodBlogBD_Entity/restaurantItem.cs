using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodBlogBD_Entity
{
    public class restaurantItem
    {
        //restaurant
        [Key]
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "Only Characters are allowed.")]
        public string itemName { get; set; }
        public int restaurantID { get; set; }        
        public int itemCategory { get; set; }
        public int itemSection { get; set; }
        [Required]
        public int itemPrice { get; set; }
        [Required]
        public string otherInfo { get; set; }


        [ForeignKey("restaurantID")]
        public virtual List<Restaurant_info> Restaurant_info { get; set; }
        [ForeignKey("itemCategory")]
        public virtual Item_Category Item_Category { get; set; }
        [ForeignKey("itemSection")]
        public virtual Item_Section Item_Section { get; set; }
    }
}
