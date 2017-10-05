using FoodBlogBD_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoogBlogBD.Models
{
    public class BlogListModel
    {
        public int postID { get; set; }
        public string postHeadline { get; set; }
        public string postContent { get; set; }
        public string postPicture { get; set; }
        public DateTime postDate { get; set; }
        public int postGivenUserID { get; set; }
        public string postGivenUserName { get; set; }
    }
}