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
        public int Id { get; set; }
        public string itemName { get; set; }
        public int restaurantID { get; set; }        
        public int itemCategory { get; set; }
        public int itemSection { get; set; }
        public int itemPrice { get; set; }
        public string otherInfo { get; set; }
        public string itemPicture { get; set; }

    }
}
