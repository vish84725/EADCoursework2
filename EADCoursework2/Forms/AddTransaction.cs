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
    public partial class AddTransaction : Form
    {
        public enum TransactionState { Income, Expense};

        private TextFieldControl mTitleField;
        private DateFieldControl mDateField;
        private TimePickerControl mTimeField;
        private DropDownFieldControl mPayerField, mPayeeField;
        private MultiTextFieldControl mNotesField;
        private TransactionState SelectedTransactionState;

        public AddTransaction()
        {
            InitializeComponent();
            toggleIncome.Click += ToggleIncome_Click;
            toggleExpense.Click += ToggleExpense_Click;
        }


        private void AddTransaction_Load(object sender, EventArgs e)
        {
            InitializeUIComponents();
            CreateIncomeForm();
            SelectedTransactionState = TransactionState.Income;
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

            mPayeeField = new DropDownFieldControl();
            mPayeeField.LabelKey = "Payee";

            mPayerField = new DropDownFieldControl();
            mPayerField.LabelKey = "Payer";

            mNotesField = new MultiTextFieldControl();
            mNotesField.LabelKey = "Notes";

            toggleExpense.ToggleItemName = "Expense";
            toggleIncome.ToggleItemName = "Income";

            toggleIncome.ToggleControl(true);
        }

        #region Private Methods
        private void CreateIncomeForm()
        {
            if(mTimeField != null &&
                mTitleField != null && 
                mDateField != null && 
                mPayerField != null && 
                mNotesField != null)
            {
                flowPnlInputs.Controls.Add(mTitleField);
                flowPnlInputs.Controls.Add(mDateField);
                flowPnlInputs.Controls.Add(mTimeField);
                flowPnlInputs.Controls.Add(mPayerField);
                flowPnlInputs.Controls.Add(mNotesField);
            }
        }

        private void CreateExpenseeForm()
        {
            if (mTimeField != null &&
                mTitleField != null &&
                mDateField != null &&
                mPayerField != null &&
                mNotesField != null)
            {
                flowPnlInputs.Controls.Add(mTitleField);
                flowPnlInputs.Controls.Add(mDateField);
                flowPnlInputs.Controls.Add(mTimeField);
                flowPnlInputs.Controls.Add(mPayeeField);
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
                    flowPnlInputs.Controls.Remove(mPayerField);
                    flowPnlInputs.Controls.Remove(mNotesField);
                }

                if(mPayeeField != null)
                {
                    flowPnlInputs.Controls.Remove(mPayeeField);
                }
                if(mPayerField != null)
                {
                    flowPnlInputs.Controls.Remove(mPayerField);
                }
                return true;
            }
            catch(Exception)
            {
                return false;
            }

        }
        #endregion

        #region Event Handlers
        private void ToggleExpense_Click(object sender, EventArgs e)
        {
            if(SelectedTransactionState != TransactionState.Expense)
            {
                if (ResetForm())
                {
                    CreateExpenseeForm();
                    SelectedTransactionState = TransactionState.Expense;
                }
                toggleIncome.ToggleControl(false);
                toggleExpense.ToggleControl(true);
            }

        }

        private void ToggleIncome_Click(object sender, EventArgs e)
        {
            if(SelectedTransactionState != TransactionState.Income)
            {
                if (ResetForm())
                {
                    CreateIncomeForm();
                    SelectedTransactionState = TransactionState.Income;
                }
                toggleIncome.ToggleControl(true);
                toggleExpense.ToggleControl(false);
            }

        }
        #endregion
    }
}
