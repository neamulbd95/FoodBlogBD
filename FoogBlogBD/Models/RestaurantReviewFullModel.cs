using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoogBlogBD.Models
{
    public class RestaurantReviewFullModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPic { get; set; }
        public int restID { get; set; }
        public DateTime ReviewGivenDate { get; set; }
    }
}