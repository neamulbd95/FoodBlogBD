using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoogBlogBD.Models
{
    public class UserPostCommentModel
    {
        public int Id { get; set; }
        public string CommentContent { get; set; }
        public int postId { get; set; }
        public DateTime commentDate { get; set; }
        public int userId { get; set; }
        public string userName { get; set; }
        public string userProPic { get; set; }
    }
}