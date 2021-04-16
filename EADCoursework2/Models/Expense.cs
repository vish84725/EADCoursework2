using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EADCoursework2.Models
{
    public class Expense: Transaction
    {
        [JsonIgnore]
        public Payee Payee { get; set; }

        [JsonProperty("payeeid")]
        public int PayeeId { get; set; }

        public Expense()
        {

        }
        public Expense(String title, DateTime date, DateTime time, Payee payee, String notes)
        {
            this.Title = title;
            this.Date = date;
            this.Time = time;
            this.Payee = payee;
            this.Notes = notes;
        }
    }
}
