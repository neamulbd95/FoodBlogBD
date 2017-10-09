using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodBlogBD_Entity
{
    public class User_Comment
    {
        [Key]
        public int Id { get; set; }
        public int postID { get; set; }
        public string commentContent { get; set; }
        public DateTime commentDate { get; set; }
        public int userID { get; set; }

    }
}
