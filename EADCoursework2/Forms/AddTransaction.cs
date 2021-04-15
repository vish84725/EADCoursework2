using EADCoursework2.CustomControls.InputControls;
using EADCoursework2.DAL;
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
        private ITransactionService mTransactionService;
        AddPayerPayee form;

        public AddTransaction()
        {
            InitializeComponent();
            toggleIncome.Click += ToggleIncome_Click;
            toggleExpense.Click += ToggleExpense_Click;
        }


        private void AddTransaction_Load(object sender, EventArgs e)
        {
            InitializeUIComponents();
            Init();
            CreateIncomeForm();

        }

        private void Init()
        {
            try
            {
                mTransactionService = new TransactionService();
                SelectedTransactionState = TransactionState.Income;
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

            mPayeeField = new DropDownFieldControl();
            mPayeeField.LabelKey = "Payee";
            mPayeeField.MoveToAddWindow = this.NavigateAddPayerPayee;

            mPayerField = new DropDownFieldControl();
            mPayerField.LabelKey = "Payer";
            mPayerField.MoveToAddWindow = this.NavigateAddPayerPayee;

            mNotesField = new MultiTextFieldControl();
            mNotesField.LabelKey = "Notes";

            toggleExpense.ToggleItemName = "Expense";
            toggleIncome.ToggleItemName = "Income";

            toggleIncome.ToggleControl(true);
        }

        private void RefreshData()
        {
            LoadData();
        }
        private async void LoadData()
        {
            try
            {
                if (SelectedTransactionState == TransactionState.Income)
                {
                    if (mPayerField != null)
                    {
                        await LoadPayers();
                    }
                }
                else if (SelectedTransactionState == TransactionState.Expense)
                {
                    if (mPayeeField != null)
                    {
                        await LoadPayees();
                    }
                }

            }
            catch(Exception e)
            {

            }
        }

        private async Task LoadPayers()
        {
            try
            {
                if (mTransactionService != null)
                {
                    if (mPayerField != null)
                    {
                        var payers = await mTransactionService.GetAllPayers();
                        List<object> objList = new List<object>();
                        foreach(var item in payers)
                        {
                            objList.Add(item);
                        }
                        if(payers != null && payers.Count > 0)
                        {
                            mPayerField.PopulateComboBox(objList, "Name", "PayerId");
                        }
                    }
                }

            }
            catch(Exception)
            {

            }

        }

        private async Task LoadPayees()
        {
            try
            {
                if (mTransactionService != null)
                {
                    if (mPayeeField != null)
                    {
                        var payers = await mTransactionService.GetAllPayees();
                        List<object> objList = new List<object>();
                        foreach (var item in payers)
                        {
                            objList.Add(item);
                        }
                        if (payers != null && payers.Count > 0)
                        {
                            mPayeeField.PopulateComboBox(objList, "Name", "PayerId");
                        }
                    }
                }

            }
            catch (Exception)
            {

            }

        }

        #region Private Methods
        private void NavigateAddPayerPayee ()
        {
            this.form = new AddPayerPayee();
            this.form.OnCloseCallback = this.RefreshData;
            this.form.Show();
        }

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
            LoadData();
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
            LoadData();
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
                    SelectedTransactionState = TransactionState.Expense;
                    CreateExpenseeForm();
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
                    SelectedTransactionState = TransactionState.Income;
                    CreateIncomeForm();
                }
                toggleIncome.ToggleControl(true);
                toggleExpense.ToggleControl(false);
            }

        }
        #endregion
    }
}
