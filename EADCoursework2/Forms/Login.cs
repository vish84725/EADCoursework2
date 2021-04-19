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
    public partial class Login : Form
    {
        //MyWalletAPI API;
        IUserService mUserService;
        public Login()
        {
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            InitializeUIComponents();
            Init();

        }


        #region Private Methods
        private void Init()
        {
            try
            {
                //API = new MyWalletAPI();
                mUserService = new UserService();
            }
            catch (Exception)
            {

            }
        }

        private void InitializeUIComponents()
        {
            textFieldUsername.LabelKey = "Username";
            textFieldPassword.LabelKey = "Password";
            textFieldPassword.MakeFieldPasswordType();
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

        private async Task<User> LoginUserAsync(User user)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                var loggedInUser = await mUserService.LoginUser(user);
                if (loggedInUser != null && loggedInUser.UserId != 0)
                    return loggedInUser;
                Cursor.Current = Cursors.Default;
                return null;
            }
            catch(Exception e)
            {
                Cursor.Current = Cursors.Default;
                return null;
            }

        }

        #endregion

        #region Event Handlers
        private void lblRegister_Click(object sender, EventArgs e)
        {
            Register form = new Register();
            form.ShowDialog();

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if(ValidateFields())
            {
                User user = new User()
                {
                    Username = textFieldUsername.LabelValue,
                    Password = textFieldPassword.LabelValue,
                };

                var loggedInUser = await LoginUserAsync(user);
                if (loggedInUser != null)
                {
                    Program.OpenDashboardOnClose = true;
                    Program.LoggedInUser = loggedInUser;
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
