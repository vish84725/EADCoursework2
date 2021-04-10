using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EADCoursework2.Models
{
    public class Expense: Transaction
    {
        public Payer Payer { get; set; }

        public Expense(String title, DateTime date, DateTime time, Payer payer, String notes)
        {
            this.Title = title;
            this.Date = date;
            this.Time = time;
            this.Payer = payer;
            this.Notes = notes;
        }
    }
}
