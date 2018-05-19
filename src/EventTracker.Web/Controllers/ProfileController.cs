using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventTracker.Model;
using EventTracker.Model.Data;

namespace EventTracker.Web.Controllers
{
    public class ProfileController : Controller
    {
        //
        // GET: /Profile/

        public void Submit()
        {
            string username = null;
            string password = null;
            bool isExistingUser = false;
            HttpCookie cookie = null;
            Profile profile = null;

            if (Request.Form["username"] != null && Request.Form["password"] != null)
            {
                username = Request.Form["username"];
                password = Request.Form["password"];
                isExistingUser = !ProfileManager.IsUsernameValid(username);
            }

            if (!isExistingUser)
            {
                profile = ProfileManager.CreateProfile(username, password);
            }
            else
            {
                profile = ProfileManager.GetProfile(username, password);
            }

            if (profile != null)
            {
                cookie = new HttpCookie("jwProfileCookie");
                cookie.Values["u"] = profile.Username;
                cookie.Values["p"] = profile.Password;
                Response.AppendCookie(cookie);
            }

            Response.Redirect("/");
        }

        public void LogOut()
        {
            HttpCookie cookie = null;

            cookie = new HttpCookie("jwProfileCookie");
            cookie.Expires = DateTime.Now.AddDays(-1);

            Response.Cookies.Add(cookie);
            Response.Redirect("/");
        }

    }
}
