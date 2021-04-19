using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EADCoursework2.Models
{
    public class WalletSummaryDTO
    {

        [JsonProperty("currentbalance")]
        public double CurrentBalance { get; set; }
        [JsonProperty("lastweekbalance")]
        public double LastWeekBalance { get; set; }
        [JsonProperty("lastmonthbalance")]
        public double LastMonthBalance { get; set; }
    }
}
