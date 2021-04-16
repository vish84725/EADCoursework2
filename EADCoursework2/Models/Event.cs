using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EADCoursework2.Models
{
    public class Event
    {

        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("title")]
        public String Title { get; set; }
        [JsonProperty("date")]
        public List<DateTime> Date { get; set; }
        [JsonProperty("time")]
        public DateTime Time { get; set; }
        [JsonProperty("notes")]
        public String Notes { get; set; }
        [JsonProperty("isrecurrent")]
        public bool IsRecurrent { get; set; }
        [JsonProperty("recurrenttype")]
        public RecurrentType RecurrentType { get; set; }
        [JsonProperty("userid")]
        public int UserId { get; set; }
        [JsonIgnore]
        public virtual User User { get; set; }

        //for dange api calls
        [JsonProperty("fromdate")]
        public DateTime FromDate { get; set; }
        [JsonProperty("todate")]
        public DateTime ToDate { get; set; }
    }

    public enum RecurrentType
    {
        EveryWeek = 1, EveryMonth = 2, EveryDay = 3
    }
}
