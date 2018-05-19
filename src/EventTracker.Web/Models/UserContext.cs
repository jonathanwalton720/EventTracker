using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EventTracker.Model;
using EventTracker.Model.Data;

namespace EventTracker.Web.Models
{
    public class UserContext
    {
        HttpCookie Cookie { get; set; }

        public Profile Profile { get; set; }

        public IEnumerable<Event> Events { get; set; }

        public bool IsLoggedIn 
        {
            get { return Profile != null; }  
        }

        public UserContext() : this(null) { }

        public UserContext(HttpCookie cookie)
        {
            this.Cookie = cookie;

            if (cookie == null || cookie["u"] == null || cookie["p"] == null)
            {
                this.Profile = null;
            }
            else
            {
                string username = cookie["u"];
                string password = cookie["p"];
                this.Profile = ProfileManager.GetProfile(username, password, true);
            }

            this.Events = EventManager.GetEvents();
        }




    }

}