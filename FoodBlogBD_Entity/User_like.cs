using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodBlogBD_Entity
{
    public class User_like
    {
        [Key]
        public int Id { get; set; }
        public int postID { get; set; }
        public int userID { get; set; }

        [ForeignKey("postID")]
        public virtual User_Post User_Post { get; set; }
        [ForeignKey("userID")]
        public virtual User_info User_info { get; set; }
    }
}
