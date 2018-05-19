using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventTracker.Model;
using EventTracker.Model.Data;
using EventTracker.Web.Models;

namespace EventTracker.Web.Controllers
{
    public class EventController : Controller
    {
        //
        // GET: /Event/

        public ActionResult Index()
        {
            UserContext user = new UserContext(Request.Cookies["jwProfileCookie"]);

            return View(user);
        }

    }
}
