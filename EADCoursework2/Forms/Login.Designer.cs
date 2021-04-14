
namespace EADCoursework2.Forms
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textFieldUsername = new EADCoursework2.CustomControls.InputControls.TextFieldControl();
            this.textFieldPassword = new EADCoursework2.CustomControls.InputControls.TextFieldControl();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblRegister = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textFieldUsername
            // 
            this.textFieldUsername.BackColor = System.Drawing.Color.White;
            this.textFieldUsername.LabelValue = "";
            this.textFieldUsername.Location = new System.Drawing.Point(51, 100);
            this.textFieldUsername.Name = "textFieldUsername";
            this.textFieldUsername.Size = new System.Drawing.Size(700, 40);
            this.textFieldUsername.TabIndex = 0;
            // 
            // textFieldPassword
            // 
            this.textFieldPassword.BackColor = System.Drawing.Color.White;
            this.textFieldPassword.LabelValue = "";
            this.textFieldPassword.Location = new System.Drawing.Point(51, 161);
            this.textFieldPassword.Name = "textFieldPassword";
            this.textFieldPassword.Size = new System.Drawing.Size(700, 40);
            this.textFieldPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Image = global::EADCoursework2.Properties.Resources.DoneButton;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(575, 284);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(125, 40);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblRegister.Location = new System.Drawing.Point(535, 221);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(165, 13);
            this.lblRegister.TabIndex = 3;
            this.lblRegister.Text = "Not already an user? Signup here";
            this.lblRegister.Click += new System.EventHandler(this.lblRegister_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textFieldPassword);
            this.Controls.Add(this.textFieldUsername);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.InputControls.TextFieldControl textFieldUsername;
        private CustomControls.InputControls.TextFieldControl textFieldPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblRegister;
    }
}