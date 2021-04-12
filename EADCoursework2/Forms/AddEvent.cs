using EADCoursework2.CustomControls.InputControls;
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
            CreateTaskForm();
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
                flowPnlInputs.Controls.Add(mDateField);
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
        #endregion

    }
}
