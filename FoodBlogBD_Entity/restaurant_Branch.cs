using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodBlogBD_Entity
{
    public class restaurant_Branch
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string branchName { get; set; }
        public int restaurantID { get; set; }
        [Required]
        public string branchArea { get; set; }

        [ForeignKey("restaurantID")]
        public virtual List<Restaurant_info> Restaurant_info { get; set; }

    }
}
