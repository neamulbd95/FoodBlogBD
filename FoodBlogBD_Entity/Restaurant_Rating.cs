using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodBlogBD_Entity
{
    public class Restaurant_Rating
    {
        [Key]
        public int Id { get; set; }
        public int restaurantID { get; set; }
        public int totalRating { get; set; }
        public int ratingGivenUser { get; set; }
        public int avarageRating { get; set; }

        //[ForeignKey("restaurantID")]
        //public virtual List<Restaurant_info> Restaurant_info { get; set; }
    }
}
