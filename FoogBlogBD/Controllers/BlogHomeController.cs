using FoodBlogBD_Entity;
using FoodBlogBD_ServiceLayer;
using FoogBlogBD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoogBlogBD.Controllers
{
    public class BlogHomeController : Controller
    {
        //
        // GET: /BlogHome/
        iUser_Post_Service posts = Service_Center.GetUser_Post_Service();
        iUser_info_Service users = Service_Center.GetUser_info_Service();
        iUser_Comment_Service comments = Service_Center.GetUser_Comment_Service();
        iUser_like_Service likes = Service_Center.GetUser_like_Service();

        public ActionResult Index()
        {
            IEnumerable<User_Post> postList = posts.GetGetAllValues();
            List<BlogListModel> AllBlogList = new List<BlogListModel>();

            foreach(User_Post up in postList)
            {
                BlogListModel blog = new BlogListModel();

                blog.postID = up.Id;
                blog.postHeadline = up.postHeadline;
                blog.postContent = up.postContent;
                blog.postPicture = Url.Content(up.postPicture);
                blog.postDate = up.postDate;
                blog.postGivenUserID = up.userID;
                blog.postGivenUserName = users.GetSingle(up.userID).fullName;

                AllBlogList.Add(blog);

            }
            ViewBag.userName = Session["UserName"];
            ViewBag.logged = Session["loggedOn"];

            return View(AllBlogList);
        }

        public ActionResult PostDetails(int id)
        {
            User_Post post = posts.GetSingle(id);

            ViewBag.postId = post.Id;
            ViewBag.postHead = post.postHeadline;
            ViewBag.postCont = post.postContent;
            ViewBag.postPic = post.postPicture;
            ViewBag.date = post.postDate;
            ViewBag.userID = post.userID;
            ViewBag.userName = users.GetSingle(post.userID).fullName;

            IEnumerable<User_Comment> commentList = comments.GetComments(id);
            List<UserPostCommentModel> fullCommentDetailList = new List<UserPostCommentModel>();

            foreach(User_Comment c in commentList)
            {
                UserPostCommentModel fullCommentDetail = new UserPostCommentModel();

                fullCommentDetail.Id = c.Id;
                fullCommentDetail.CommentContent = c.commentContent;
                fullCommentDetail.postId = id;
                fullCommentDetail.commentDate = c.commentDate;
                fullCommentDetail.userId = c.userID;
                fullCommentDetail.userName = users.GetSingle(c.userID).fullName;
                fullCommentDetail.userProPic = Url.Content(users.GetSingle(c.userID).profilePicture);

                fullCommentDetailList.Add(fullCommentDetail);
            }
            ViewBag.userID = Session["UserID"];
            ViewBag.userName = Session["UserName"];
            ViewBag.logged = Session["loggedOn"];

            return View(fullCommentDetailList);
        }

        public ActionResult RangeByDate()
        {
            if (Request.Form["dateRange"] != null)
            {
                DateTime from = Convert.ToDateTime(Request.Form["fromDate"]);
                DateTime to = Convert.ToDateTime(Request.Form["toDate"]);

                IEnumerable<User_Post> postList = posts.GetByDateRange(from, to);
                List<BlogListModel> AllBlogList = new List<BlogListModel>();

                foreach (User_Post up in postList)
                {
                    BlogListModel blog = new BlogListModel();

                    blog.postID = up.Id;
                    blog.postHeadline = up.postHeadline;
                    blog.postContent = up.postContent;
                    blog.postPicture = Url.Content(up.postPicture);
                    blog.postDate = up.postDate;
                    blog.postGivenUserID = up.userID;
                    blog.postGivenUserName = users.GetSingle(up.userID).fullName;

                    AllBlogList.Add(blog);

                }
                ViewBag.userName = Session["UserName"];
                ViewBag.logged = Session["loggedOn"];

                return View(AllBlogList);
            }
            return View();
        }
    }
}
