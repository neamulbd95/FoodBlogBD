using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodBlogBD_Entity
{
    public class User_Post
    {
        [Key]   
        public int Id { get; set; }
        [Required]
        public string postHeadline { get; set; }
        [Required]
        public string postContent { get; set; }
        public int  userID { get; set; }
        public DateTime postDate { get; set; }
        public string postPicture { get; set; }

    }
}
