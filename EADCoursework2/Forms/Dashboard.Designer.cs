
namespace EADCoursework2.Forms
{
    partial class Dashboard
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
            this.tabHeaderMySettings = new EADCoursework2.CustomControls.DashboardTabHeaderItem();
            this.tabHeaderMyReports = new EADCoursework2.CustomControls.DashboardTabHeaderItem();
            this.tabHeaderMyEvents = new EADCoursework2.CustomControls.DashboardTabHeaderItem();
            this.tabHeaderMyWallet = new EADCoursework2.CustomControls.DashboardTabHeaderItem();
            this.SuspendLayout();
            // 
            // tabHeaderMySettings
            // 
            this.tabHeaderMySettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(193)))), ((int)(((byte)(32)))));
            this.tabHeaderMySettings.Location = new System.Drawing.Point(603, 1);
            this.tabHeaderMySettings.Name = "tabHeaderMySettings";
            this.tabHeaderMySettings.Size = new System.Drawing.Size(209, 70);
            this.tabHeaderMySettings.TabIndex = 3;
            // 
            // tabHeaderMyReports
            // 
            this.tabHeaderMyReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(193)))), ((int)(((byte)(32)))));
            this.tabHeaderMyReports.Location = new System.Drawing.Point(396, 1);
            this.tabHeaderMyReports.Name = "tabHeaderMyReports";
            this.tabHeaderMyReports.Size = new System.Drawing.Size(210, 70);
            this.tabHeaderMyReports.TabIndex = 2;
            // 
            // tabHeaderMyEvents
            // 
            this.tabHeaderMyEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(193)))), ((int)(((byte)(32)))));
            this.tabHeaderMyEvents.Location = new System.Drawing.Point(192, 1);
            this.tabHeaderMyEvents.Name = "tabHeaderMyEvents";
            this.tabHeaderMyEvents.Size = new System.Drawing.Size(208, 70);
            this.tabHeaderMyEvents.TabIndex = 1;
            // 
            // tabHeaderMyWallet
            // 
            this.tabHeaderMyWallet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(193)))), ((int)(((byte)(32)))));
            this.tabHeaderMyWallet.Location = new System.Drawing.Point(-6, 1);
            this.tabHeaderMyWallet.Name = "tabHeaderMyWallet";
            this.tabHeaderMyWallet.Size = new System.Drawing.Size(200, 70);
            this.tabHeaderMyWallet.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabHeaderMySettings);
            this.Controls.Add(this.tabHeaderMyReports);
            this.Controls.Add(this.tabHeaderMyEvents);
            this.Controls.Add(this.tabHeaderMyWallet);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.DashboardTabHeaderItem tabHeaderMyWallet;
        private CustomControls.DashboardTabHeaderItem tabHeaderMyEvents;
        private CustomControls.DashboardTabHeaderItem tabHeaderMyReports;
        private CustomControls.DashboardTabHeaderItem tabHeaderMySettings;
    }
}