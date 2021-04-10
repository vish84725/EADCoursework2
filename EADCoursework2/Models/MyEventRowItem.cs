using EADCoursework2.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EADCoursework2.Models
{
    public class MyEventRowItem
    {
        public String Date { get; set; }
        public String Day { get; set; }
        public List<MyEventSubRowItem> Items { get; set; }
    }

    public class MyEventSubRowItem
    {
        public String Title { get; set; }
        public String Description { get; set; }
        public String Value { get; set; }
        public MyEventType Type { get; set; }
        public Color TypeColor
        {
            get
            {
                switch (Type)
                {
                    case MyEventType.Appointment:
                        return Constants.MW_MYEVENT_PURPLE;
                    case MyEventType.Task:
                        return Constants.MW_MYEVENT_BLUE;
                    case MyEventType.Income:
                        return Constants.MW_Green;
                    case MyEventType.Expense:
                        return Constants.MW_MYEVENT_ORANGE;
                    default:
                        return Color.Transparent;
                }
            }
        }
    }

    public enum MyEventType
    {
        Task, Appointment,Income,Expense
    }
}
