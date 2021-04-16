using EADCoursework2.CustomControls.InputControls;
using EADCoursework2.DAL;
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

namespace EADCoursework2.Forms
{
    public partial class AddEvent : Form
    {
        public enum EventState { Task, Appointment };
        public User User { get; set; }
        private IEventService mEventService;

        private TextFieldControl mTitleField;
        private DateFieldControl mDateField;
        private TimePickerControl mTimeField;
        private RecurrentDropDownFieldControl mRecurrentField;
        private MultiTextFieldControl mNotesField;
        private EventState SelectedEventState;

        public AddEvent()
        {
            InitializeComponent();
            toggleTask.Click += ToggleTask_Click;
            toggleAppointment.Click += ToggleAppointment_Click;
        }

        private void AddEvent_Load(object sender, EventArgs e)
        {
            InitializeUIComponents();
            Init();
            CreateTaskForm();
        }

        private void Init()
        {
            try
            {
                mEventService = new EventService();
            }
            catch(Exception)
            {

            }
        }

        private void InitializeUIComponents()
        {
            //set controls
            mTitleField = new TextFieldControl();
            mTitleField.LabelKey = "Title";

            mDateField = new DateFieldControl();
            mDateField.LabelKey = "Date";

            mTimeField = new TimePickerControl();
            mTimeField.LabelKey = "Time";

            mRecurrentField = new RecurrentDropDownFieldControl();
            mRecurrentField.LabelKey = "Recurrent";
            List<object> objList = new List<object>();
            foreach(var item in Constants.RecurrentDateTypes)
            {
                objList.Add(item);
            }
            mRecurrentField.PopulateComboBox(objList, "Name", "Id");


            mNotesField = new MultiTextFieldControl();
            mNotesField.LabelKey = "Notes";

            toggleAppointment.ToggleItemName = "Appointment";
            toggleTask.ToggleItemName = "Task";

            toggleTask.ToggleControl(true);
        }

        #region Private Methods
        private void CreateTaskForm()
        {
            if (mTimeField != null &&
                mTitleField != null &&
                mDateField != null &&
                mRecurrentField != null &&
                mNotesField != null)
            {
                flowPnlInputs.Controls.Add(mTitleField);
                flowPnlInputs.Controls.Add(mDateField);
                flowPnlInputs.Controls.Add(mTimeField);
                flowPnlInputs.Controls.Add(mRecurrentField);
                flowPnlInputs.Controls.Add(mNotesField);
            }
        }

        private void CreateAppointmentForm()
        {
            if (mTimeField != null &&
                mTitleField != null &&
                mDateField != null &&
                mRecurrentField != null &&
                mNotesField != null)
            {
                flowPnlInputs.Controls.Add(mTitleField);
                flowPnlInputs.Controls.Add(mDateField);
                flowPnlInputs.Controls.Add(mTimeField);
                flowPnlInputs.Controls.Add(mRecurrentField);
                flowPnlInputs.Controls.Add(mNotesField);
            }
        }

        private bool ResetForm()
        {
            try
            {
                if (mTimeField != null &&
                    mTitleField != null &&
                    mDateField != null &&
                    mNotesField != null)
                {
                    mTitleField.LabelValue = string.Empty;
                    mNotesField.LabelValue = string.Empty;

                    flowPnlInputs.Controls.Remove(mTitleField);
                    flowPnlInputs.Controls.Remove(mDateField);
                    flowPnlInputs.Controls.Remove(mTimeField);
                    flowPnlInputs.Controls.Remove(mNotesField);
                }

                if (mRecurrentField != null)
                {
                    flowPnlInputs.Controls.Remove(mRecurrentField);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        private RecurrentType GetRecurrentType()
        {
            var dropdownValue = mRecurrentField.SelectedDropDownValue as RecurrentDateTypes;
            if (dropdownValue.Id == (int)RecurrentType.EveryWeek)
                return RecurrentType.EveryWeek;
            else if (dropdownValue.Id == (int)RecurrentType.EveryMonth)
                return RecurrentType.EveryMonth;
            else if (dropdownValue.Id == (int)RecurrentType.EveryDay)
                return RecurrentType.EveryDay;
            return 0;
        }
        private List<DateTime> GetRecurrentDates()
        {
            List<DateTime> datesList = new List<DateTime>();
            if(mRecurrentField.CheckBoxValue)
            {
                var dropdownValue = mRecurrentField.SelectedDropDownValue as RecurrentDateTypes;
                if (dropdownValue.Id == (int)RecurrentType.EveryWeek)
                {
                    for(int i =0; i< 10; i++)
                    {
                        var date = mDateField.Date.AddDays(i * 7);
                        datesList.Add(date);
                    }              
                }
                else if (dropdownValue.Id == (int)RecurrentType.EveryMonth)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        var date = mDateField.Date.AddMonths(i * 1);
                        datesList.Add(date);
                    }
                }
                else if (dropdownValue.Id == (int)RecurrentType.EveryDay)
                {
                    for (int i = 0; i < 20; i++)
                    {
                        var date = mDateField.Date.AddDays(i * 1);
                        datesList.Add(date);
                    }
                }
            }
            else
            {
                datesList.Add(mDateField.Date);
            }
            return datesList;
        }
        private async Task<Appointment> CreateAppointment(Appointment appointment)
        {
            try
            {
                if (mEventService != null)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    var inc = await mEventService.CreateAppointment(appointment);
                    Cursor.Current = Cursors.Default;
                    return inc;
                }
                return null;
            }
            catch (Exception e)
            {
                Cursor.Current = Cursors.Default;
                return null;
            }
        }

        private async Task<TaskEvent> CreateTask(TaskEvent task)
        {
            try
            {
                if (mEventService != null)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    var t = await mEventService.CreateTask(task);
                    Cursor.Current = Cursors.Default;
                    return t;
                }
                return null;
            }
            catch (Exception e)
            {
                Cursor.Current = Cursors.Default;
                return null;
            }
        }
        private bool ValidateTaskFields()
        {
            if (mTitleField.LabelValue == null || mTitleField.LabelValue.Trim() == string.Empty)
                return false;
            if (mNotesField.LabelValue == null || mNotesField.LabelValue.Trim() == string.Empty)
                return false;
            if (mDateField.Date == null)
                return false;
            if (mTimeField.Time == null)
                return false;
            return true;
        }

        private bool ValidateAppointmentFields()
        {
            if (mTitleField.LabelValue == null || mTitleField.LabelValue.Trim() == string.Empty)
                return false;
            if (mNotesField.LabelValue == null || mNotesField.LabelValue.Trim() == string.Empty)
                return false;
            if (mDateField.Date == null)
                return false;
            if (mTimeField.Time == null)
                return false;
            return true;
        }
        #endregion


        #region Event Handlers
        private void ToggleAppointment_Click(object sender, EventArgs e)
        {
            if (SelectedEventState != EventState.Appointment)
            {
                if (ResetForm())
                {
                    CreateAppointmentForm();
                    SelectedEventState = EventState.Appointment;
                }
                toggleTask.ToggleControl(false);
                toggleAppointment.ToggleControl(true);
            }
        }

        private void ToggleTask_Click(object sender, EventArgs e)
        {
            if (SelectedEventState != EventState.Task)
            {
                if (ResetForm())
                {
                    CreateTaskForm();
                    SelectedEventState = EventState.Task;
                }
                toggleTask.ToggleControl(true);
                toggleAppointment.ToggleControl(false);
            }
        }
        private async void btnSaveEvent_Click(object sender, EventArgs e)
        {
            if (SelectedEventState == EventState.Appointment)
            {
                if (ValidateAppointmentFields())
                {
                    var appointment = new Appointment()
                    {
                        Date = GetRecurrentDates(),
                        Notes = mNotesField.LabelValue.Trim(),
                        Time = mTimeField.Time,
                        Title = mTitleField.LabelValue.Trim(),
                        User = this.User,
                        UserId = this.User.UserId,
                        IsRecurrent = mRecurrentField.CheckBoxValue,
                        RecurrentType = GetRecurrentType()
                    };
                    var app = await CreateAppointment(appointment);
                    if (app != null && app.Id != 0)
                    {
                        MessageBox.Show("Appointment created successfully");
                    }

                }
                else
                {
                    MessageBox.Show("Please fill all the requried fields");
                }
            }
            else if (SelectedEventState == EventState.Task)
            {
                if (ValidateTaskFields())
                {
                    var task = new TaskEvent()
                    {
                        Date = GetRecurrentDates(),
                        Notes = mNotesField.LabelValue.Trim(),
                        Time = mTimeField.Time,
                        Title = mTitleField.LabelValue.Trim(),
                        User = this.User,
                        UserId = this.User.UserId,
                        IsRecurrent = mRecurrentField.CheckBoxValue,
                        RecurrentType = GetRecurrentType()
                    };
                    var t = await CreateTask(task);
                    if (t != null && t.Id != 0)
                    {
                        MessageBox.Show("Task created successfully");
                    }

                }
                else
                {
                    MessageBox.Show("Please fill all the requried fields");
                }
            }
        }
        #endregion
    }
}
