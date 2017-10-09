using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodBlogBD_Entity
{
    public class Restaurant_user_Review
    {
        public int Id { get; set; }
        public string ReviewContent { get; set; }
        public int userID { get; set; }
        public int restID { get; set; }
        public DateTime ReviewDate { get; set; }
    }
}
