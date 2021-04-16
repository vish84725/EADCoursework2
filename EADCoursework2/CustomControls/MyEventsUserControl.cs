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
            Init();
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

        private async void MyEventsUserControl_Load(object sender, EventArgs e)
        {
            InitializeUIComponents();
            await LoadAllData();
        }

        #region Private Methods
        private async Task LoadAllData()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                List<MyEventsRowItem> myEventsRows = new List<MyEventsRowItem>();
                var incomes = await LoadIncomes();
                var expenses = await LoadExpenses();
                var tasks = await LoadTasks();
                var appointments = await LoadAppointments();

                if(CurrentViewState == ViewDisplayState.All ||CurrentViewState == ViewDisplayState.Events)
                {
                    PopulateAppointments(appointments, myEventsRows);
                    PopulateTasks(tasks, myEventsRows);
                }
                if(CurrentViewState == ViewDisplayState.All || CurrentViewState == ViewDisplayState.Transactions)
                {
                    PopulateExpenses(expenses, myEventsRows);
                    PopulateIncomes(incomes, myEventsRows);
                }
                myEventsFlowLayout.Controls.Clear();
                foreach (var row in myEventsRows)
                {
                    myEventsFlowLayout.Controls.Add(row);
                }
            }
            catch(Exception)
            {

            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
            

        }
        private void PopulateIncomes(List<Income> incomes, List<MyEventsRowItem> myEventsRows)
        {
            if(incomes != null && incomes.Count >0)
            {
                foreach (var income in incomes)
                {
                    var subItem = new MyEventSubRowItem()
                    {
                        Description = income.Notes,
                        Title = income.Title,
                        Type = MyEventType.Income,
                        Value = $"Rs. {income.Amount.ToString()}"
                    };
                    var dateValue = $"{income.Date.Day} of {income.Date.ToString("MMMM")}";
                    var dayValue = income.Date.DayOfWeek.ToString();

                    var alreadyAddedItem = myEventsRows.Where(row => row.Day == dayValue && row.Date == dateValue).FirstOrDefault();
                    if (alreadyAddedItem == null)
                    {
                        var item = new MyEventsRowItem()
                        {
                            Date = dateValue,
                            Day = dayValue
                        };
                        item.RowItems.Add(subItem);
                        myEventsRows.Add(item);
                    }
                    else
                    {
                        alreadyAddedItem.RowItems.Add(subItem);
                    }
                }
            }
            
        }
        private void PopulateExpenses(List<Expense> expenses, List<MyEventsRowItem> myEventsRows)
        {
            if(expenses != null && expenses.Count >0)
            {
                foreach (var expense in expenses)
                {
                    var subItem = new MyEventSubRowItem()
                    {
                        Description = expense.Notes,
                        Title = expense.Title,
                        Type = MyEventType.Expense,
                        Value = $"Rs. {expense.Amount.ToString()}"
                    };
                    var dateValue = $"{expense.Date.Day} of {expense.Date.ToString("MMMM")}";
                    var dayValue = expense.Date.DayOfWeek.ToString();

                    var alreadyAddedItem = myEventsRows.Where(row => row.Day == dayValue && row.Date == dateValue).FirstOrDefault();
                    if (alreadyAddedItem == null)
                    {
                        var item = new MyEventsRowItem()
                        {
                            Date = dateValue,
                            Day = dayValue
                        };
                        item.RowItems.Add(subItem);
                        myEventsRows.Add(item);
                    }
                    else
                    {
                        alreadyAddedItem.RowItems.Add(subItem);
                    }
                }
            }
        
        }
        private void PopulateAppointments(List<Appointment> appointments, List<MyEventsRowItem> myEventsRows)
        {
            if (appointments != null && appointments.Count > 0)
            {
                foreach (var appointment in appointments)
                {
                    var subItem = new MyEventSubRowItem()
                    {
                        Description = appointment.Notes,
                        Title = appointment.Title,
                        Type = MyEventType.Appointment,
                        Value = appointment.Time.ToString("t")
                    };

                    if (appointment.Date != null && appointment.Date.Count > 0)
                    {
                        foreach (var recurringDay in appointment.Date)
                        {
                            var dateValue = $"{recurringDay.Day} of {recurringDay.ToString("MMMM")}";
                            var dayValue = recurringDay.DayOfWeek.ToString();

                            var alreadyAddedItem = myEventsRows.Where(row => row.Day == dayValue && row.Date == dateValue).FirstOrDefault();
                            if (alreadyAddedItem == null)
                            {
                                var item = new MyEventsRowItem()
                                {
                                    Date = dateValue,
                                    Day = dayValue
                                };
                                item.RowItems.Add(subItem);
                                myEventsRows.Add(item);
                            }
                            else
                            {
                                alreadyAddedItem.RowItems.Add(subItem);
                            }
                        }
                    }
                }
            }
        }
        private void PopulateTasks(List<TaskEvent> tasks, List<MyEventsRowItem> myEventsRows)
        {
            if(tasks != null && tasks.Count >0 )
            {
                foreach (var task in tasks)
                {
                    var subItem = new MyEventSubRowItem()
                    {
                        Description = task.Notes,
                        Title = task.Title,
                        Type = MyEventType.Task,
                        Value = task.Time.ToString("t")
                    };

                    if (task.Date != null && task.Date.Count > 0)
                    {
                        foreach (var recurringDay in task.Date)
                        {
                            var dateValue = $"{recurringDay.Day} of {recurringDay.ToString("MMMM")}";
                            var dayValue = recurringDay.DayOfWeek.ToString();

                            var alreadyAddedItem = myEventsRows.Where(row => row.Day == dayValue && row.Date == dateValue).FirstOrDefault();
                            if (alreadyAddedItem == null)
                            {
                                var item = new MyEventsRowItem()
                                {
                                    Date = dateValue,
                                    Day = dayValue
                                };
                                item.RowItems.Add(subItem);
                                myEventsRows.Add(item);
                            }
                            else
                            {
                                alreadyAddedItem.RowItems.Add(subItem);
                            }
                        }
                    }
                }
            }
           
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

        private async void btnFilter_Click(object sender, EventArgs e)
        {
            await LoadAllData();
        }
    }
}
