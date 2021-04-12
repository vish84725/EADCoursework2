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

namespace EADCoursework2.CustomControls.Components
{
    public partial class ToggleItemControl : UserControl
    {
        public String ToggleItemName
        {
            get
            {
                return lblName.Text;
            }
            set
            {
                lblName.Text = value;
            }
        }

        public bool IsToggleOn;

        public ToggleItemControl()
        {
            InitializeComponent();
            ToggleControl(false);
        }

        public void ToggleControl(bool isSelected)
        {
            this.IsToggleOn = isSelected;
            if (this.IsToggleOn)
            {
                this.BackColor = Constants.MW_Toggle_Gray;
                this.lblName.ForeColor = Constants.MW_White;
            }
            else
            {
                this.BackColor = Constants.MW_White;
                this.lblName.ForeColor = Constants.MW_Toggle_Gray;
            }
        }
    }
}
