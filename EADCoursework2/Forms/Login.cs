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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            InitializeUIComponents();
        }


        #region Private Methods
        private void InitializeUIComponents()
        {
            textFieldUsername.LabelKey = "Username";
            textFieldPassword.LabelKey = "Password";
        }

        private bool ValidateFields()
        {
            if(textFieldUsername.LabelValue == null || textFieldUsername.LabelValue.Trim() == string.Empty)
            {
                return false;
            }
            if (textFieldPassword.LabelValue == null || textFieldPassword.LabelValue.Trim() == string.Empty)
            {
                return false;
            }
            return true;
        }

        private bool LoginUser(User user)
        {
            return true;
        }

        #endregion

        #region Event Handlers
        private void lblRegister_Click(object sender, EventArgs e)
        {
            Register form = new Register();
            form.ShowDialog();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(ValidateFields())
            {
                User user = new User()
                {
                    Username = textFieldUsername.LabelValue,
                    Password = textFieldPassword.LabelValue,
                };

                if (LoginUser(user))
                {
                    Program.OpenDashboardOnClose = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect password or username");
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
