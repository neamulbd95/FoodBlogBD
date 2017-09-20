using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodBlogBD_Entity
{
    public class Restaurant_FoodCategory
    {
        [Key]
        public int Id { get; set; }
        public int categoryID { get; set; }
        public int restaurantID { get; set; }

    }
}
