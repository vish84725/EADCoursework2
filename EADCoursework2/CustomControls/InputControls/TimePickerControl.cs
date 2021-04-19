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
    public partial class TimePickerControl : UserControl
    {
        public DateTime Time
        {
            get
            {
                return timePicker.Value;
            }
            set
            {
                timePicker.Value = value;
            }
        }
        public String LabelKey
        {
            set
            {
                lblKey.Text = value;
            }
        }
        public TimePickerControl()
        {
            InitializeComponent();
        }
    }
}
