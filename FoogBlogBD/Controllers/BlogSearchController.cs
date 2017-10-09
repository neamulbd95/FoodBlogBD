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
    public class BlogSearchController : Controller
    {
        //
        // GET: /BlogSearch/
        iUser_Post_Service posts = Service_Center.GetUser_Post_Service();
        iUser_info_Service users = Service_Center.GetUser_info_Service();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult search()
        {
            if (Request.Form["serachBtn"] != null)
            {
                string searchKeyword = Request.Form["nameSearch"];

                IEnumerable<User_Post> postList = posts.GetByContent(searchKeyword);
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
                return View("Index", "Home");
            }
        }

    }
}
