using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EADCoursework2.CustomControls.InputControls
{
    public partial class DateFieldControl : UserControl
    {
        public DateTime Date
        {
            get
            {
                return datePicker.Value;
            }
            set
            {
                datePicker.Value = value;
            }
        }
        public String LabelKey
        {
            set
            {
                lblKey.Text = value;
            }
        }
        public DateFieldControl()
        {
            InitializeComponent();
        }

        private void picBoxCalnedar_Click(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = new DateTimePicker();
            dateTimePicker.Focus();
        }
    }
}
