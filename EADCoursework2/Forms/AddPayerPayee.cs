using EADCoursework2.CustomControls.InputControls;
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

namespace EADCoursework2.Forms
{
    public partial class AddPayerPayee : Form
    {
        public enum PayerPayee { Payee, Payer };

        private TextFieldControl mNameField, mAddressField;
        private PayerPayee SelectedPayerPayee;
        private ITransactionService mTransactionService;
        public Action OnCloseCallback;

        public AddPayerPayee()
        {
            InitializeComponent();
            togglePayer.Click += TogglePayer_Click;
            togglePayee.Click += TogglePayee_Click;
        }

        private void AddEvent_Load(object sender, EventArgs e)
        {
            InitializeUIComponents();
            Init();
            CreatePayerForm();
            SelectedPayerPayee = PayerPayee.Payer;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            OnCloseCallback?.Invoke();
        }

        private void InitializeUIComponents()
        {
            //set controls
            mNameField = new TextFieldControl();
            mNameField.LabelKey = "Name";

            mAddressField = new TextFieldControl();
            mAddressField.LabelKey = "Address";

            togglePayee.ToggleItemName = "Payee";
            togglePayer.ToggleItemName = "Payer";

            togglePayer.ToggleControl(true);
        }

        private void Init()
        {
            try
            {
                mTransactionService = new TransactionService();
            }
            catch(Exception)
            {

            }
        }

        #region Private Methods
        private bool ValidateInputFields()
        {
            if (mNameField.LabelValue == null || mNameField.LabelValue.Trim() == string.Empty)
                return false;
            if (mAddressField.LabelValue == null || mAddressField.LabelValue.Trim() == string.Empty)
                return false;

            return true;
        }
        private void CreatePayeeForm()
        {
            if (mNameField != null &&
                mAddressField != null)
            {
                flowPnlInputs.Controls.Add(mNameField);
                flowPnlInputs.Controls.Add(mAddressField);
            }
        }

        private void CreatePayerForm()
        {
            if (mNameField != null &&
                mAddressField != null)
            {
                flowPnlInputs.Controls.Add(mNameField);
                flowPnlInputs.Controls.Add(mAddressField);
            }
        }

        private bool ResetForm()
        {
            try
            {
                if (mNameField != null &&
                    mAddressField != null)
                {
                    mNameField.LabelValue = string.Empty;
                    mAddressField.LabelValue = string.Empty;

                    flowPnlInputs.Controls.Remove(mNameField);
                    flowPnlInputs.Controls.Remove(mAddressField);
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
        private void TogglePayer_Click(object sender, EventArgs e)
        {
            if (SelectedPayerPayee != PayerPayee.Payer)
            {
                if (ResetForm())
                {
                    CreatePayerForm();
                    SelectedPayerPayee = PayerPayee.Payer;
                }
                togglePayer.ToggleControl(true);
                togglePayee.ToggleControl(false);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if(ValidateInputFields())
            {
                if(SelectedPayerPayee == PayerPayee.Payee)
                {
                    Payee payee = new Payee
                    {
                        DateOfBirth = DateTime.Today,
                        Address = mAddressField.LabelValue,
                        Name = mNameField.LabelValue
                    };
                    Payee p = await mTransactionService.CreatePayee(payee);
                    if(p.PayeeId != 0)
                    {
                        MessageBox.Show("Payee Successfully created!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Couldn't create payee. Something went wrong. please try again later");
                    }
                }
                else if(SelectedPayerPayee == PayerPayee.Payer)
                {
                    Payer payer = new Payer
                    {
                        DateOfBirth = DateTime.Today,
                        Address = mAddressField.LabelValue,
                        Name = mNameField.LabelValue
                    };
                    Payer p = await mTransactionService.CreatePayer(payer);
                    if (p.PayerId != 0)
                    {
                        MessageBox.Show("Payer Successfully created!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Couldn't create payer. Something went wrong. please try again later");
                    }
                }
            }
        }

        private void TogglePayee_Click(object sender, EventArgs e)
        {
            if (SelectedPayerPayee != PayerPayee.Payee)
            {
                if (ResetForm())
                {
                    CreatePayeeForm();
                    SelectedPayerPayee = PayerPayee.Payee;
                }
                togglePayer.ToggleControl(false);
                togglePayee.ToggleControl(true);
            }
        }
        #endregion

    }
}
