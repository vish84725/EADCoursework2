
namespace EADCoursework2.Forms
{
    partial class Register
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
            this.textFieldConfirmPassword = new EADCoursework2.CustomControls.InputControls.TextFieldControl();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textFieldUsername
            // 
            this.textFieldUsername.BackColor = System.Drawing.Color.White;
            this.textFieldUsername.LabelValue = "";
            this.textFieldUsername.Location = new System.Drawing.Point(69, 96);
            this.textFieldUsername.Name = "textFieldUsername";
            this.textFieldUsername.Size = new System.Drawing.Size(700, 40);
            this.textFieldUsername.TabIndex = 0;
            // 
            // textFieldPassword
            // 
            this.textFieldPassword.BackColor = System.Drawing.Color.White;
            this.textFieldPassword.LabelValue = "";
            this.textFieldPassword.Location = new System.Drawing.Point(69, 153);
            this.textFieldPassword.Name = "textFieldPassword";
            this.textFieldPassword.Size = new System.Drawing.Size(700, 40);
            this.textFieldPassword.TabIndex = 1;
            // 
            // textFieldConfirmPassword
            // 
            this.textFieldConfirmPassword.BackColor = System.Drawing.Color.White;
            this.textFieldConfirmPassword.LabelValue = "";
            this.textFieldConfirmPassword.Location = new System.Drawing.Point(69, 222);
            this.textFieldConfirmPassword.Name = "textFieldConfirmPassword";
            this.textFieldConfirmPassword.Size = new System.Drawing.Size(700, 40);
            this.textFieldConfirmPassword.TabIndex = 2;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Image = global::EADCoursework2.Properties.Resources.DoneButton;
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.Location = new System.Drawing.Point(595, 308);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(125, 40);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.textFieldConfirmPassword);
            this.Controls.Add(this.textFieldPassword);
            this.Controls.Add(this.textFieldUsername);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.InputControls.TextFieldControl textFieldUsername;
        private CustomControls.InputControls.TextFieldControl textFieldPassword;
        private CustomControls.InputControls.TextFieldControl textFieldConfirmPassword;
        private System.Windows.Forms.Button btnRegister;
    }
}