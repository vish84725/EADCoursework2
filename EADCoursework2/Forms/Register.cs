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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            InitializeUIComponents();
        }

        #region Private Methods
        private void InitializeUIComponents()
        {
            textFieldUsername.LabelKey = "Username";
            textFieldPassword.LabelKey = "Password";
            textFieldConfirmPassword.LabelKey = "Confirm Password";
        }

        private bool ValidateFields()
        {
            if (textFieldUsername.LabelValue == null || textFieldUsername.LabelValue.Trim() == string.Empty)
            {
                return false;
            }
            if (textFieldPassword.LabelValue == null || textFieldPassword.LabelValue.Trim() == string.Empty)
            {
                return false;
            }
            if (textFieldConfirmPassword.LabelValue == null || textFieldConfirmPassword.LabelValue.Trim() == string.Empty)
            {
                return false;
            }
            return true;
        }

        private bool RegisterUser(User user)
        {
            return true;
        }
        #endregion


        #region Event Handlers
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                User user = new User()
                {
                    Username = textFieldUsername.LabelValue,
                    Password = textFieldPassword.LabelValue,
                };

                if (RegisterUser(user))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Coldnt register user");
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }

        }
        #endregion

    }
}
