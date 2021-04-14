using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EADCoursework2.Models
{
    public class User
    {
        [JsonProperty ("username")]
        public String Username { get; set; }
        [JsonProperty("password")]
        public String Password { get; set; }
        [JsonProperty("id")]
        public int UserId { get; set; }
    }
}
