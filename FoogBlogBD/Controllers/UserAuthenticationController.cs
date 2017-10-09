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
    public class UserAuthenticationController : Controller
    {
        //
        // GET: /UserAuthentication/
        iUser_info_Service users = Service_Center.GetUser_info_Service();
        iUser_Authentication_Service logs = Service_Center.GetUser_Authentication_Service();

        public ActionResult Index()
        {
            ViewBag.ErrorMsg = Session["logInErr"];
            return View();
        }

        public ActionResult checkLogin()
        {
            string username = Request.Form["username"];
            string password = Request.Form["pass"];

            if (logs.GetSingle(username, password) == null)
            {
                Session["logInErr"] = "Log In Falied. Check UserName Or Passwor";

                return RedirectToAction("Index");
            }
            else
            {
                if(username == "admin")
                {
                    Session["UserName"] = username;
                    Session["loggedOn"] = true;
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    Session["UserID"] = users.GetByUserName(username).Id;
                    Session["UserName"] = username;
                    Session["loggedOn"] = true;
                    return RedirectToAction("Index", "Home");
                }               
            }
            
        }

        public ActionResult signUp()
        {
            ViewBag.errMsg = Session["signUpError"];
            return View();
        }

        [HttpPost]
        public ActionResult signUp(HttpPostedFileBase profilePicture)
        {
            if(Request.Form["signUP"] != null)
            {
                if (Request.Form["passtxt"] == Request.Form["rePasstxt"])
                {
                    User_info user = new User_info();
                    User_Authentication logged = new User_Authentication();

                    if (profilePicture != null && profilePicture.ContentLength > 0)
                    {

                        var filename = Path.GetFileName(profilePicture.FileName);
                        var path = Path.Combine(Server.MapPath("~/images"), filename);
                        profilePicture.SaveAs(path);

                        user.userName = Request.Form["usernametxt"];
                        user.fullName = Request.Form["fullnametxt"];
                        user.email = Request.Form["emailtxt"];
                        user.Gender = Request.Form["genderSelect"];
                        user.DOB = Convert.ToDateTime(Request.Form["DOB"]);
                        user.profilePicture = "~/images/" + filename.ToString();

                        logged.userName = Request.Form["usernametxt"];
                        logged.passWord = Request.Form["passtxt"];

                        users.Insert(user);
                        logs.Insert(logged);

                        return RedirectToAction("Index");
                    }
                    else
                    {
                        Session["signUpError"] = "Picture Is not Uploaded";
                        return RedirectToAction("signUp");
                    }
                }
                else
                {
                    Session["signUpError"] = "Passwords did not matched";
                    return RedirectToAction("signUp");
                }               
            }

                
            return RedirectToAction("Index","Home");
        }

        public ActionResult LogOut()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
