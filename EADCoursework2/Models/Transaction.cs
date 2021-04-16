using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EADCoursework2.Models
{
    public class Transaction
    {
        [JsonProperty("id")]
        public int TransactionId { get; set; }
        [JsonProperty("title")]
        public String Title { get; set; }
        [JsonProperty("date")]
        public DateTime Date { get; set; }
        [JsonProperty("time")]
        public DateTime Time { get; set; }
        [JsonProperty("notes")]
        public String Notes { get; set; }

        [JsonProperty("userid")]
        public int UserId { get; set; }
        [JsonIgnore]
        public User User { get; set; }
        public String TimeString
        {
            get
            {
                return Time.ToString();
            }
        }
    }
}
