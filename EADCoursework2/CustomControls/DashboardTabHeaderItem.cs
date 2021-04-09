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
    public partial class DashboardTabHeaderItem : UserControl
    {
        #region Private Attributes
        private TabHeaderItem mHeaderType;
        private bool mTabSelected;
        #endregion

        #region Properties
        public Bitmap TabIcon
        {
            get
            {
                switch (this.mHeaderType)
                {
                    case TabHeaderItem.MyEvents:
                        return mTabSelected == true ? Properties.Resources.MyEventsWhite : Properties.Resources.MyEventsBlack;
                    case TabHeaderItem.MyWallet:
                        return mTabSelected == true ? Properties.Resources.MyWalletImage : Properties.Resources.MyWalletBlack;
                    case TabHeaderItem.MySettings:
                        return mTabSelected == true ? Properties.Resources.MySettingsWhite : Properties.Resources.MySettingsBlack;
                    case TabHeaderItem.MyReports:
                        return mTabSelected == true ? Properties.Resources.MyReportsWhite : Properties.Resources.MyReportsBlack;
                }
                return null;
            }
        }
        #endregion
        public DashboardTabHeaderItem()
        {
            InitializeComponent();
        }

        private void DashboardTabHeaderItem_Load(object sender, EventArgs e)
        {
            ToggleSelectedState();
        }

        #region Private Methods
        private void InitializeUIComponents()
        {
            ToggleSelectedState();
        }
        #endregion

        #region Public Methods
        public void SetHeaderItemType(TabHeaderItem tabHeaderItem)
        {
            this.mHeaderType = tabHeaderItem;
            string tabTitle = "";
            Bitmap tabIcon = null;

            switch(tabHeaderItem)
            {
                case TabHeaderItem.MyEvents:
                    tabTitle = Properties.Resources.DashboardTabMyEvents;
                    tabIcon = Properties.Resources.MyEventsBlack;
                    break;
                case TabHeaderItem.MyWallet:
                    tabTitle = Properties.Resources.DashboardTabMyWallet;
                    tabIcon = Properties.Resources.MyWalletBlack;
                    break;
                case TabHeaderItem.MySettings:
                    tabTitle = Properties.Resources.DashboardTabMySettings;
                    tabIcon = Properties.Resources.MySettingsBlack;
                    break;
                case TabHeaderItem.MyReports:
                    tabTitle = Properties.Resources.DashboardTabMyReports;
                    tabIcon = Properties.Resources.MyReportsBlack;
                    break;
            }

            if (tabIcon != null)
                iconPictureBox.Image = tabIcon;
            if (!string.IsNullOrEmpty(tabTitle))
                lblHeaderTitle.Text = tabTitle;
        }

        public void ToggleSelectedState(bool isSelected = false)
        {
            this.mTabSelected = isSelected;
            if(isSelected)
            {
                this.BackColor = Constants.MW_Green;
                iconPictureBox.Image = TabIcon;
                lblHeaderTitle.BackColor = Constants.MW_Green;
                lblHeaderTitle.ForeColor = Constants.MW_White;
            }
            else
            {
                this.BackColor = Constants.MW_Gray;
                iconPictureBox.Image = TabIcon;
                lblHeaderTitle.BackColor = Constants.MW_Gray;
                lblHeaderTitle.ForeColor = Constants.MW_TextGray;

            }
        }
        #endregion

        #region Event Handlers
        #endregion
    }
}
