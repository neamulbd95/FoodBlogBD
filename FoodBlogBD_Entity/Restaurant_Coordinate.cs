using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodBlogBD_Entity
{
    public class Restaurant_Coordinate
    {
        [Key]
        public int Id { get; set; }
        public int restId { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
    }
}
