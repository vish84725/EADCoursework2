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
    public partial class AddPayerPayee : Form
    {
        public enum PayerPayee { Payee, Payer };

        private TextFieldControl mNameField, mAddressField;
        private PayerPayee SelectedPayerPayee;

        public AddPayerPayee()
        {
            InitializeComponent();
            togglePayer.Click += TogglePayer_Click;
            togglePayee.Click += TogglePayee_Click;
        }

        private void AddEvent_Load(object sender, EventArgs e)
        {
            InitializeUIComponents();
            CreatePayerForm();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(ValidateInputFields())
            {

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
