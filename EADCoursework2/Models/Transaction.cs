using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EADCoursework2.Models
{
    public class Transaction
    {
        public String Title { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public String Notes { get; set; }
        public String TimeString
        {
            get
            {
                return Time.ToString();
            }
        }
    }
}
