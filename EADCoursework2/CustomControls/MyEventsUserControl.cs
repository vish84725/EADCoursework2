using EADCoursework2.Forms;
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
    public partial class MyEventsUserControl : UserControl
    {
        public User LoggedInUser { get; set; }
        public enum ViewDisplayState
        {
            All,Events, Transactions
        };
        private ViewDisplayState CurrentViewState;

        public MyEventsUserControl()
        {
            InitializeComponent();
            toggleAll.Click += ToggleAll_Click;
            toggleEvents.Click += ToggleEvents_Click;
            toggleTransactions.Click += ToggleTransactions_Click;
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

            //set toggles
            toggleAll.ToggleItemName = "All";
            toggleEvents.ToggleItemName = "Events";
            toggleTransactions.ToggleItemName = "Transactions";

            ToggleDisplayState(ViewDisplayState.All);
        }

        private void LoadData()
        {
            PopulateMyEvents();
        }

        private void ToggleDisplayState(ViewDisplayState currentState)
        {
            CurrentViewState = currentState;
            toggleAll.ToggleControl(false);
            toggleEvents.ToggleControl(false);
            toggleTransactions.ToggleControl(false);

            switch(currentState)
            {
                case ViewDisplayState.All:
                    toggleAll.ToggleControl(true);
                    break;
                case ViewDisplayState.Events:
                    toggleEvents.ToggleControl(true);
                    break;
                case ViewDisplayState.Transactions:
                    toggleTransactions.ToggleControl(true);
                    break;
            }
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

        #region Event Handlers
        private void myEventsFlowLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MyEventsUserControl_Click(object sender, EventArgs e)
        {

        }

        private void addEventPictureBox_Click(object sender, EventArgs e)
        {
            AddEvent form = new AddEvent();
            form.User = LoggedInUser;
            form.ShowDialog();
        }
        private void ToggleTransactions_Click(object sender, EventArgs e)
        {
            ToggleDisplayState(ViewDisplayState.Transactions);
        }

        private void ToggleEvents_Click(object sender, EventArgs e)
        {
            ToggleDisplayState(ViewDisplayState.Events);
        }

        private void ToggleAll_Click(object sender, EventArgs e)
        {
            ToggleDisplayState(ViewDisplayState.All);
        }
        #endregion

    }
}
