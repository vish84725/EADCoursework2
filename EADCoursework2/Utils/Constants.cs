using EADCoursework2.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EADCoursework2.Utils
{
    public static class Constants
    {
        public static Color MW_Green = Color.FromArgb(22, 193, 32);
        public static Color MW_Gray = Color.FromArgb(222, 227, 229);
        public static Color MW_Toggle_Gray = Color.FromArgb(92, 97, 102);
        public static Color MW_TabGray = Color.FromArgb(92, 97, 102);
        public static Color MW_TextGray = Color.FromArgb(121, 124, 130);
        public static Color MW_MYEVENT_BLUE = Color.FromArgb(80, 137, 225);
        public static Color MW_MYEVENT_GREEN = Color.FromArgb(50, 165, 51);
        public static Color MW_MYEVENT_PURPLE = Color.FromArgb(145, 115, 181);
        public static Color MW_MYEVENT_ORANGE = Color.FromArgb(252, 149, 0);
        public static Color MW_MYEVENT_RED = Color.FromArgb(225, 39, 48);
        public static Color MW_White = Color.White;

        public const String BASEURL = "https://localhost:44314/";

        public static List<RecurrentDateTypes> RecurrentDateTypes = new List<RecurrentDateTypes>()
        {
            new RecurrentDateTypes()
            {
                Id = 1,
                Name ="Every Week"
            },
            new RecurrentDateTypes()
            {
                Id = 2,
                Name ="Every Month"
            },
            new RecurrentDateTypes()
            {
                Id = 3,
                Name ="Every Day"
            }
        };
        
    }
}
