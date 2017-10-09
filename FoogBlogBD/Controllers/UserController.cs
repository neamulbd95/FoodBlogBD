using FoodBlogBD_Entity;
using FoodBlogBD_ServiceLayer;
using FoogBlogBD.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoogBlogBD.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/
        iUser_info_Service users = Service_Center.GetUser_info_Service();
        iUser_Post_Service posts = Service_Center.GetUser_Post_Service();

        public ActionResult Index()
        {

            if (Session["loggedOn"] != null)
            {
                int userId = Convert.ToInt32(Session["UserID"]);
                User_info user = users.GetSingle(userId);

                ViewBag.UserName = user.userName;
                ViewBag.FullName = user.fullName;
                ViewBag.Email = user.email;
                ViewBag.ProfilePicture = user.profilePicture;
                var date = user.DOB;
                ViewBag.DateOfBirth = date.ToString("ddd, MMM d, yyyy");
                ViewBag.Gender = user.Gender;

                IEnumerable<User_Post> postList = posts.GetByUser(userId);
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

            else
            {
                return View();
            }
            
        }

        public ActionResult OtherUsersProfile(int Id)
        {
            return View();
        }
    }
}
