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
    public partial class MyEventsUserControl : UserControl
    {
        public MyEventsUserControl()
        {
            InitializeComponent();
        }

        private void MyEventsUserControl_Load(object sender, EventArgs e)
        {
            InitializeUIComponents();
            LoadData();
        }

        #region Private Methods
        private void InitializeUIComponents()
        {
            //set background color
            this.BackColor = Constants.MW_Gray;
        }

        private void LoadData()
        {
            PopulateMyEvents();
        }

        private void PopulateMyEvents()
        {
            for(int i =0; i <10; i++)
            {
                var item = new MyEventsRowItem()
                {
                    Date = "JAN 27",
                    Day = "FRI"
                };
                myEventsFlowLayout.Controls.Add(item);
            }
        }
        #endregion

        private void myEventsFlowLayout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
