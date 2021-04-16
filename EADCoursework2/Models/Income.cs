using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EADCoursework2.Models
{
    public class Income : Transaction
    {
        [JsonIgnore]
        public Payer Payer { get; set; }

        [JsonProperty("payerid")]
        public int PayerId { get; set; }
        
        public Income()
        {

        }
        public Income(String title, DateTime date, DateTime time, Payer payer, String notes)
        {
            this.Title = title;
            this.Date = date;
            this.Time = time;
            this.Payer = payer;
            this.Notes = notes;
        }
    }
}
