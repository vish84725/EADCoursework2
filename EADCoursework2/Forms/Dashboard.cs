using EADCoursework2.CustomControls;
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

namespace EADCoursework2.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            InitializeUIComponents();
            tabHeaderMyEvents.Click += TabHeaderMyEvents_Click;
            tabHeaderMyReports.Click += TabHeaderMyReports_Click;
            tabHeaderMySettings.Click += TabHeaderMySettings_Click;
            tabHeaderMyWallet.Click += TabHeaderMyWallet_Click;
        }

        #region Private Methods 
        private void InitializeUIComponents()
        {
            //Set tab headers details
            tabHeaderMyEvents.SetHeaderItemType(Utils.TabHeaderItem.MyEvents);
            tabHeaderMyWallet.SetHeaderItemType(Utils.TabHeaderItem.MyWallet);
            tabHeaderMyReports.SetHeaderItemType(Utils.TabHeaderItem.MyReports);
            tabHeaderMySettings.SetHeaderItemType(Utils.TabHeaderItem.MySettings);

            //Selet My Wallet as Default tab
            SelectTab(TabHeaderItem.MyWallet);

            //Add Sub View to main panel
            this.panelMain.Controls.Add(new MyEventsUserControl());
        }

        private void SelectTab(TabHeaderItem tabHeaderItem)
        {
            tabHeaderMyEvents.ToggleSelectedState(false);
            tabHeaderMyWallet.ToggleSelectedState(false);
            tabHeaderMyReports.ToggleSelectedState(false);
            tabHeaderMySettings.ToggleSelectedState(false);

            switch (tabHeaderItem)
            {
                case TabHeaderItem.MyEvents:
                    tabHeaderMyEvents.ToggleSelectedState(true);
                    break;
                case TabHeaderItem.MyWallet:
                    tabHeaderMyWallet.ToggleSelectedState(true);
                    break;
                case TabHeaderItem.MySettings:
                    tabHeaderMySettings.ToggleSelectedState(true);
                    break;
                case TabHeaderItem.MyReports:
                    tabHeaderMyReports.ToggleSelectedState(true);
                    break;
            }
        }
        #endregion

        #region Event Handlers
        private void TabHeaderMySettings_Click(object sender, EventArgs e)
        {
            SelectTab(TabHeaderItem.MySettings);
        }

        private void TabHeaderMyReports_Click(object sender, EventArgs e)
        {
            SelectTab(TabHeaderItem.MyReports);
        }

        private void TabHeaderMyEvents_Click(object sender, EventArgs e)
        {
            SelectTab(TabHeaderItem.MyEvents);
        }

        private void TabHeaderMyWallet_Click(object sender, EventArgs e)
        {
            SelectTab(TabHeaderItem.MyWallet);
        }
        #endregion


    }
}
