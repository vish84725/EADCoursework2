using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EADCoursework2.Models
{
    public class DateRangeDTO
    {
        [JsonProperty("fromdate")]
        public DateTime FromDate { get; set; }
        [JsonProperty("todate")]
        public DateTime ToDate { get; set; }
    }
}
