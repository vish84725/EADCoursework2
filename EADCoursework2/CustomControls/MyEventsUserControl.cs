using EADCoursework2.DAL;
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
        private ITransactionService mTransactionService;
        private IEventService mEventService;
        private List<Transaction> mTransactions;
        private List<Event> mEvents;
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

        private void Init()
        {
            try
            {
                mTransactionService = new TransactionService();
                mEventService = new EventService();
            }
            catch(Exception)
            {

            }
        }

        private void MyEventsUserControl_Load(object sender, EventArgs e)
        {
            InitializeUIComponents();
            LoadData();
        }

        #region Private Methods
        private async Task LoadAllData()
        {
            var incomes = await LoadIncomes();
            var expenses = await LoadExpenses();
            var tasks = await LoadTasks();
            var appointments = await LoadAppointments();
        }
        private async Task<List<Appointment>> LoadAppointments()
        {
            try
            {
                var appointments = await mEventService.GetAllAppointmentRange(new List<Appointment>()
                {
                    new Appointment()
                    {
                        FromDate = datePickerFrom.Value,
                        ToDate = datePickerTo.Value
                    }
                });
                return appointments;
            }
            catch(Exception e)
            {
                return null;
            }
        }
        private async Task<List<TaskEvent>> LoadTasks()
        {
            try
            {
                var tasks = await mEventService.GetAllTasksRange(new List<TaskEvent>()
                {
                    new TaskEvent()
                    {
                        FromDate = datePickerFrom.Value,
                        ToDate = datePickerTo.Value
                    }
                });
                return tasks;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        private async Task<List<Income>> LoadIncomes()
        {
            try
            {
                var tasks = await mTransactionService.GetAllIncomeRange(new List<Income>()
                {
                    new Income()
                    {
                        FromDate = datePickerFrom.Value,
                        ToDate = datePickerTo.Value
                    }
                });
                return tasks;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        private async Task<List<Expense>> LoadExpenses()
        {
            try
            {
                var expenses = await mTransactionService.GetAllExpenseRange(new List<Expense>()
                {
                    new Expense()
                    {
                        FromDate = datePickerFrom.Value,
                        ToDate = datePickerTo.Value
                    }
                });
                return expenses;
            }
            catch (Exception e)
            {
                return null;
            }
        }
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

        private void btnFilter_Click(object sender, EventArgs e)
        {

        }
    }
}
