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
    public partial class TextFieldControl : UserControl
    {
        public String LabelKey
        {
            set
            {
                lblKey.Text = value;
            }
        }
        public String LabelValue
        {
            get
            {
                return txtBoxValue.Text;
            }
            set
            {
                txtBoxValue.Text = value;
            }
        }

        public void MakeFieldPasswordType()
        {
            txtBoxValue.PasswordChar = '*';
        }

        public TextFieldControl()
        {
            InitializeComponent();
        }
    }
}
