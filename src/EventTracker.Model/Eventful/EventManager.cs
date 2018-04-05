using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using System.Text;
using System.IO;

namespace jonathanwalton720.Lib
{
    public static class EventManager
    {

        private const string _ApplicationKey = "mptn92GJdw7N4D7s";

        public static Event[] GetEvents()
        {
            string url = "http://api.eventful.com/json/events/search?location=San+Diego&date=Past&sort_order=date&-description:%20&page_size=9&sort_direction=descending&app_key=" + _ApplicationKey;

            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;

            return request.Deserialize<EventfulResponse>().EventList.Events;

        }
    }
}
