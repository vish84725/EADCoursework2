using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EADCoursework2.Models
{
    public class Income : Transaction
    {
        public Payee Payee { get; set; }
        //
        public Income(String title, DateTime date, DateTime time, Payee payee, String notes)
        {
            this.Title = title;
            this.Date = date;
            this.Time = time;
            this.Payee = payee;
            this.Notes = notes;
        }
    }
}
