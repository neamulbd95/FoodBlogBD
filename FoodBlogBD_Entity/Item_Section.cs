using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodBlogBD_Entity
{
    public class Item_Section
    {
        [Key]
        public int Id { get; set; }
        public string sectionName { get; set; }
        public int categoryID { get; set; }

        [ForeignKey("categoryID")]
        public virtual Item_Category Item_Category { get; set; }

        //public List<restaurantItem> restaurantItem { get; set; }
    }
}
