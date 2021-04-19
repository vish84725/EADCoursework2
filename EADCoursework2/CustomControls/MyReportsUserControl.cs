using EADCoursework2.DAL;
using EADCoursework2.Models;
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
    public partial class MyReportsUserControl : UserControl
    {
        public class ReportType
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        private ITransactionService mTransactionService;
        private IEventService mEventService;
        private List<Income> mIncome;
        private List<Expense> mExpense;
        private List<Appointment> mAppointment;
        private List<TaskEvent> mTask;
        private List<ReportType> reportTypes = new List<ReportType>()
        {
            new ReportType(){Name = "Task", Id =1},
            new ReportType(){Name = "Appointment", Id =2},
            new ReportType(){Name = "Income", Id =3},
            new ReportType(){Name = "Expense", Id =4},
        };
        public MyReportsUserControl()
        {
            InitializeComponent();
        }

        private void MyReportsUserControl_Load(object sender, EventArgs e)
        {
            InitializeUIComponents();
            Init();

        }

        private void InitializeUIComponents()
        {
            comboBoxReportType.DataSource = reportTypes;
            comboBoxReportType.ValueMember = "Id";
            comboBoxReportType.DisplayMember = "Name";

            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.White;
        }

        private void Init()
        {
            try
            {
                mTransactionService = new TransactionService();
                mEventService = new EventService();
            }
            catch (Exception)
            {

            }
        }
        private async void LoadAppointmentData()
        {
            this.mAppointment = await LoadAppointments();
            SetAppointmentData();

        }

        private void SetAppointmentData()
        {
            if (mAppointment != null && mAppointment.Count > 0)
            {
                dataGridView1.DataSource = mAppointment;
            }
        }

        private async void LoadTaskData()
        {
            this.mTask = await LoadTasks();
            SetTaskData();

        }

        private void SetTaskData()
        {
            if (mTask != null && mTask.Count > 0)
            {
                dataGridView1.DataSource = mTask;
            }
        }
        private async void LoadExpenseData()
        {
            this.mExpense = await LoadExpenses();
            SetIncomeData();

        }

        private void SetExpenseData()
        {
            if (mExpense != null && mExpense.Count > 0)
            {
                dataGridView1.DataSource = mExpense;
            }
        }

        private async void LoadIncomeData()
        {
            this.mIncome = await LoadIncomes();
            SetIncomeData();

        }

        private void SetIncomeData()
        {
            if(mIncome != null && mIncome.Count >0)
            {
                dataGridView1.DataSource = mIncome;
            }
        }

        #region Business Methods
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
            catch (Exception e)
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
        #endregion

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if(((Int32)comboBoxReportType.SelectedValue) == 1)
            {
                LoadTaskData();
            }
            else if (((Int32)comboBoxReportType.SelectedValue) == 2)
            {
                LoadAppointmentData();
            }
            else if (((Int32)comboBoxReportType.SelectedValue) == 3)
            {
                LoadIncomeData();
            }
            else if (((Int32)comboBoxReportType.SelectedValue) == 4)
            {
                LoadExpenseData();
            }
   
        }
    }
}
