using EADCoursework2.Models;
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
    public partial class MyEventsSubRowItem : UserControl
    {
        #region Properties
        public MyEventSubRowItem Item
        {
            get; set;
        }
        #endregion
        public MyEventsSubRowItem()
        {
            InitializeComponent();
        }

        private void MyEventsSubRowItem_Load(object sender, EventArgs e)
        {
            SetData();
        }

        #region Private Methods
        private void SetData()
        {
            if(Item != null)
            {
                //set title
                if(Item.Title != null && Item.Title.Trim() != string.Empty)
                {
                    lblTitle.Text = Item.Title;
                }

                //set description
                if (Item.Description != null && Item.Description.Trim() != string.Empty)
                {
                    lblDescription.Text = Item.Description;
                }

                //set value
                if (Item.Value != null && Item.Value.Trim() != string.Empty)
                {
                    lblValue.Text = Item.Value;
                }

                //set type
                lblType.Text = Item.Type.ToString();

                //set colors
                lblDescription.ForeColor = Constants.MW_TextGray;
                lblValue.ForeColor = Constants.MW_MYEVENT_RED;
                lblType.ForeColor = Item.TypeColor;
                
            }
        }
        #endregion
    }
}
