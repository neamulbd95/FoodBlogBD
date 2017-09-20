using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodBlogBD_Entity
{
    public class Item_Category
    {
        [Key]
        public int Id { get; set; }
        public string categoryName { get; set; }

        public virtual List<Item_Section> Item_Section { get; set; }
        public virtual List<restaurantItem> restaurantItem { get; set; }

    }
}
