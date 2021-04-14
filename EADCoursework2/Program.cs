using EADCoursework2.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EADCoursework2
{
    static class Program
    {
        public static bool OpenDashboardOnClose { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            OpenDashboardOnClose = false;
            Application.Run(new Login());
            if(OpenDashboardOnClose)
            {
                Application.Run(new Dashboard());
            }
        }
    }
}
