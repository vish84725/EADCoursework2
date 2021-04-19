using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EADCoursework2.Models
{
    public class PredictionDTO
    {
        [JsonProperty("predictiondate")]
        public DateTime PredictionDate { get; set; }

        [JsonProperty("predictionvalue")]
        public double PredictionValue { get; set; }
    }
}
