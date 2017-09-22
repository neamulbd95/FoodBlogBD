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

        [ForeignKey("userID")]
        public virtual User_info User_info { get; set; }

        public virtual List<User_Comment> User_Comment { get; set; }
        public virtual List<User_like> User_like { get; set; }

        public virtual User_Post_Approval User_Post_Approval { get; set; }
    }
}
