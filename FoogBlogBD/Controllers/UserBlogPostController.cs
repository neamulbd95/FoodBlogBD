using FoodBlogBD_Entity;
using FoodBlogBD_ServiceLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoogBlogBD.Controllers
{
    public class UserBlogPostController : Controller
    {
        //
        // GET: /UserBlogPost/
        iUser_Post_Service posts = Service_Center.GetUser_Post_Service();
        iUser_Comment_Service comments = Service_Center.GetUser_Comment_Service();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult newPost(HttpPostedFileBase picture)
        {
            if (Request.Form["postBtn"] != null)
            {
                if (picture != null && picture.ContentLength > 0)
                {
                    var filename = Path.GetFileName(picture.FileName);
                    var path = Path.Combine(Server.MapPath("~/images"), filename);
                    picture.SaveAs(path);

                    User_Post post = new User_Post();

                    post.postHeadline = Request.Form["headLineName"];
                    post.postContent = Request.Form["bodyName"];
                    post.postPicture = "~/images/" + filename.ToString();
                    post.postDate = DateTime.Now.Date;
                    post.userID = Convert.ToInt32(Session["UserID"]);

                    posts.Insert(post);

                    return RedirectToAction("Index", "BlogHome");
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                return View("Index", "Home");
            }
        }

        [HttpPost]
        public ActionResult newComment()
        {
            if (Request.Form["commentName"]!= null)
            {
                User_Comment cmnt = new User_Comment();

                cmnt.commentContent = Request.Form["commentContent"];
                cmnt.postID = Convert.ToInt32(Request.Form["postId"]);
                cmnt.userID = Convert.ToInt32(Request.Form["userId"]);
                cmnt.commentDate = DateTime.Now.Date;

                comments.Insert(cmnt);

                return RedirectToAction("PostDetails", "BlogHome", new { id = Convert.ToInt32(Request.Form["postId"]) });
            }
            return View();
        }

    }
}
