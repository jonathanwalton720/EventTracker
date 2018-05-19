using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace EventTracker.Model
{
    public static class Extensions
    {
        public static T Deserialize<T>(this HttpWebRequest request)
        {
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new Exception("Could not connect to service");

                StreamReader reader = new StreamReader(response.GetResponseStream());
                JsonSerializerSettings settings = new JsonSerializerSettings()
                {
                    MissingMemberHandling = MissingMemberHandling.Ignore
                };

                string strJson = reader.ReadToEnd();
                T objJson = JsonConvert.DeserializeObject<T>(strJson, settings);

                return objJson;

            }
        }
    }
}
