using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using jonathanwalton720.Lib;
using jonathanwalton720.Lib.Data;
using jonathanwalton720.Web.Models;

namespace jonathanwalton720.Web.Controllers
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
