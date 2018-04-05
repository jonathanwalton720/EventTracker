using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace jonathanwalton720.Lib
{
    public class EventfulResponse
    {
        [JsonProperty(PropertyName = "last_item")]
        public int? LastItem { get; set; }

        [JsonProperty(PropertyName = "total_items")]
        public int? TotalItems { get; set; }

        [JsonProperty(PropertyName = "first_item")]
        public int? FirstItem { get; set; }

        [JsonProperty(PropertyName = "page_number")]
        public int? PageNumber { get; set; }

        [JsonProperty(PropertyName = "page_size")]
        public int? PageSize { get; set; }

        [JsonProperty(PropertyName = "page_items")]
        public int? PageItems { get; set; }

        [JsonProperty(PropertyName = "search_time")]
        public float SearchTime { get; set; }

        [JsonProperty(PropertyName = "page_count")]
        public int PageCount { get; set; }

        [JsonProperty(PropertyName = "events")]
        public EventList EventList { get; set; }
    }

    public class EventList
    {
        [JsonProperty(PropertyName = "event")]
        public Event[] Events { get; set; }
    }

    public class Event
    {

        //public string watching_count;
        //public string olson_path;
        //public string calendar_count;
        //public string comment_count;
        //public string region_abbr;

        [JsonProperty(PropertyName = "postal_code")]
        public string PostalCode { get; set; }

        //public string going_count;
        //public string all_day;
        //public string latitude;
        //public string groups;

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string EventfulId { get; set; }
        //public string privacy;

        [JsonProperty(PropertyName = "city_name")]
        public string CityName { get; set; }

        //public string link_count;
        //public string longitude;
        //public string country_name;
        //public string country_abbr;

        [JsonProperty(PropertyName = "region_name")]
        public string RegionName { get; set; }

        [JsonProperty(PropertyName = "start_time")]
        public DateTime StartTime { get; set; }

        //public string tz_id;

        [JsonProperty(PropertyName = "description")]
        public string Description { 
            get
            {
                return _Description;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _Description = value;
                }
            }
        }
        private string _Description = "There is no description for this event!";
        //public string modified;
        //public string venue_display;
        //public string tz_country;
        //public string performers = null;

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "venue_address")]
        public string VenueAddress { get; set; }

        //public string geocode_type;
        //public string tz_olson_path;
        //public string recur_string;
        //public string calendars;
        //public string owner;
        //public string going;
        //public string country_abbr2;
        //public string created;
        //public string venue_id;
        //public string tz_city;
        //public string stop_time;

        [JsonProperty(PropertyName = "venue_name")]
        public string VenueName { get; set; }

        [JsonProperty(PropertyName = "venue_url")]
        public string VenueUrl { get; set; }

        [JsonProperty(PropertyName = "image")]
        public Image Image { get; set; }

    }

    public class Image
    {
        [JsonProperty(PropertyName = "thumb")]
        public Thumbnail MyProperty { get; set; }
    }

    public class Thumbnail
    {
        [JsonProperty(PropertyName = "width")]
        public int Width { get; set; }

        [JsonProperty(PropertyName = "height")]
        public int Height { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
    }
}
