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
    public partial class DropDownFieldControl : UserControl
    {
        public Action MoveToAddWindow;
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
        public DropDownFieldControl()
        {
            InitializeComponent();
        }

        #region Public Methods 
        public void PopulateComboBox(List<object> list, string displayMember, string valueMember)
        {
            cmbBoxValue.DataSource = list;
            cmbBoxValue.DisplayMember = displayMember;
            cmbBoxValue.ValueMember = valueMember;
        }
        #endregion

        private void pctBoxAdd_Click(object sender, EventArgs e)
        {
            MoveToAddWindow?.Invoke();
        }
    }
}
