using EADCoursework2.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EADCoursework2.CustomControls
{
    public partial class MyEventsRowItem : UserControl
    {
        #region Properties
        public String Date
        {
            set
            {
                this.lblDate.Text = value;
            }
        }
        public String Day
        {
            set
            {
                this.lblDay.Text = value;
            }
        }
        #endregion
        public MyEventsRowItem()
        {
            InitializeComponent();

        }

        private void MyEventsRowItem_Load(object sender, EventArgs e)
        {
            InitializeUIComponents();
            PopulateSubItems();
        }

        #region Private Methods
        private void InitializeUIComponents()
        {
            lblDate.ForeColor = Color.Black;
            lblDay.ForeColor = Constants.MW_TextGray;
        }

        private void PopulateSubItems()
        {
            for(int i=0; i < 3; i ++)
            {
                subItemsFlowLayout.Controls.Add(new MyEventsSubRowItem()
                {
                    Item = new Models.MyEventSubRowItem()
                    {
                        Description = "I have an appointment for this date with Moriati, Please be ready. This will take a hour",
                        Title = "My First Appointment",
                        Type = Models.MyEventType.Appointment,
                        Value = "9.00am"
                    }
                });
            }
        }

        #endregion
    }
}
