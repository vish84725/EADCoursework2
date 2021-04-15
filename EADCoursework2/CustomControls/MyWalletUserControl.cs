using EADCoursework2.Forms;
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
    public partial class MyWalletUserControl : UserControl
    {
        public MyWalletUserControl()
        {
            InitializeComponent();
        }

        private void MyWalletUserControl_Load(object sender, EventArgs e)
        {
            InitializeUIComponents();
        }

        #region Private Methods
        private void InitializeUIComponents()
        {
            //set background color
            this.BackColor = Constants.MW_Gray;
        }
        #endregion

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            AddTransaction form = new AddTransaction();
            form.ShowDialog();
        }

        private void btnAddPayeePayer_Click(object sender, EventArgs e)
        {
            AddPayerPayee form = new AddPayerPayee();
            form.Show();
        }
    }
}
