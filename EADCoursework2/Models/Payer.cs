using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EADCoursework2.Models
{
    public class Payer
    {
        [JsonProperty("name")]
        public String Name { get; set; }
        [JsonProperty("dateofbirth")]
        public DateTime DateOfBirth { get; set; }
        [JsonProperty("address")]
        public String Address { get; set; }
        [JsonProperty("id")]
        public int PayerId { get; set; }
    }
}
