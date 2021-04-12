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
    public partial class RecurrentDropDownFieldControl : UserControl
    {
        public object SelectedDropDownValue
        {
            get
            {
                return cmbBoxValue.SelectedValue;
            }
        }
        public String LabelKey
        {
            set
            {
                lblKey.Text = value;
            }
        }
        public RecurrentDropDownFieldControl()
        {
            InitializeComponent();
        }

        private void chkBoxSelect_CheckStateChanged(object sender, EventArgs e)
        {
            var chkBox = (CheckBox)sender;
            if(chkBox.Checked)
            {
                cmbBoxValue.Visible = true;
            }
            else
            {
                cmbBoxValue.Visible = false;
            }
        }
    }
}
