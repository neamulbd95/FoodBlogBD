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
        public string itemName { get; set; }
        public int restaurantID { get; set; }
        public string Category { get; set; }
        public int itemCategory { get; set; }

        [ForeignKey("restaurantID")]
        public virtual List<Restaurant_info> Restaurant_info { get; set; }
        [ForeignKey("itemCategory")]
        public virtual List<Item_Category> Item_Category { get; set; }
    }
}
