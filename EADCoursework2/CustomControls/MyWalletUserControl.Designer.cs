
namespace EADCoursework2.CustomControls
{
    partial class MyWalletUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyWalletUserControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddPayeePayer = new System.Windows.Forms.Button();
            this.btnFinancialStatus = new System.Windows.Forms.Button();
            this.btnallTansactions = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblWeeklyAmount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMonthlyAmount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnAddPayeePayer);
            this.panel1.Controls.Add(this.btnFinancialStatus);
            this.panel1.Controls.Add(this.btnallTansactions);
            this.panel1.Location = new System.Drawing.Point(48, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 75);
            this.panel1.TabIndex = 0;
            // 
            // btnAddPayeePayer
            // 
            this.btnAddPayeePayer.BackColor = System.Drawing.Color.White;
            this.btnAddPayeePayer.FlatAppearance.BorderSize = 0;
            this.btnAddPayeePayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddPayeePayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAddPayeePayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPayeePayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPayeePayer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddPayeePayer.Location = new System.Drawing.Point(468, 14);
            this.btnAddPayeePayer.Name = "btnAddPayeePayer";
            this.btnAddPayeePayer.Size = new System.Drawing.Size(136, 47);
            this.btnAddPayeePayer.TabIndex = 2;
            this.btnAddPayeePayer.Text = "Add Payer/Payee";
            this.btnAddPayeePayer.UseVisualStyleBackColor = false;
            this.btnAddPayeePayer.Click += new System.EventHandler(this.btnAddPayeePayer_Click);
            // 
            // btnFinancialStatus
            // 
            this.btnFinancialStatus.BackColor = System.Drawing.Color.White;
            this.btnFinancialStatus.FlatAppearance.BorderSize = 0;
            this.btnFinancialStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFinancialStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFinancialStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinancialStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinancialStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFinancialStatus.Location = new System.Drawing.Point(252, 14);
            this.btnFinancialStatus.Name = "btnFinancialStatus";
            this.btnFinancialStatus.Size = new System.Drawing.Size(136, 47);
            this.btnFinancialStatus.TabIndex = 1;
            this.btnFinancialStatus.Text = "Predict My Financial Status";
            this.btnFinancialStatus.UseVisualStyleBackColor = false;
            this.btnFinancialStatus.Click += new System.EventHandler(this.btnFinancialStatus_Click);
            // 
            // btnallTansactions
            // 
            this.btnallTansactions.BackColor = System.Drawing.Color.White;
            this.btnallTansactions.FlatAppearance.BorderSize = 0;
            this.btnallTansactions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnallTansactions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnallTansactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnallTansactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnallTansactions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnallTansactions.Location = new System.Drawing.Point(38, 13);
            this.btnallTansactions.Name = "btnallTansactions";
            this.btnallTansactions.Size = new System.Drawing.Size(136, 47);
            this.btnallTansactions.TabIndex = 0;
            this.btnallTansactions.Text = "View All Transactions";
            this.btnallTansactions.UseVisualStyleBackColor = false;
            this.btnallTansactions.Click += new System.EventHandler(this.btnallTansactions_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblWeeklyAmount);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblMonthlyAmount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblTotalAmount);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnAddTransaction);
            this.panel2.Location = new System.Drawing.Point(67, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 165);
            this.panel2.TabIndex = 1;
            // 
            // lblWeeklyAmount
            // 
            this.lblWeeklyAmount.AutoSize = true;
            this.lblWeeklyAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeeklyAmount.ForeColor = System.Drawing.Color.Black;
            this.lblWeeklyAmount.Location = new System.Drawing.Point(193, 107);
            this.lblWeeklyAmount.Name = "lblWeeklyAmount";
            this.lblWeeklyAmount.Size = new System.Drawing.Size(73, 15);
            this.lblWeeklyAmount.TabIndex = 6;
            this.lblWeeklyAmount.Text = "Rs. 5000.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(193, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Last 7 days";
            // 
            // lblMonthlyAmount
            // 
            this.lblMonthlyAmount.AutoSize = true;
            this.lblMonthlyAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyAmount.ForeColor = System.Drawing.Color.Red;
            this.lblMonthlyAmount.Location = new System.Drawing.Point(16, 107);
            this.lblMonthlyAmount.Name = "lblMonthlyAmount";
            this.lblMonthlyAmount.Size = new System.Drawing.Size(77, 15);
            this.lblMonthlyAmount.TabIndex = 4;
            this.lblMonthlyAmount.Text = "-Rs. 2000.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(16, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last 30 days";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Black;
            this.lblTotalAmount.Location = new System.Drawing.Point(16, 46);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(76, 16);
            this.lblTotalAmount.TabIndex = 2;
            this.lblTotalAmount.Text = "Rs. 1270.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Wallet";
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTransaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAddTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAddTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTransaction.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddTransaction.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTransaction.Image")));
            this.btnAddTransaction.Location = new System.Drawing.Point(523, 45);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(75, 75);
            this.btnAddTransaction.TabIndex = 0;
            this.btnAddTransaction.UseVisualStyleBackColor = false;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // MyWalletUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MyWalletUserControl";
            this.Size = new System.Drawing.Size(740, 320);
            this.Load += new System.EventHandler(this.MyWalletUserControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddPayeePayer;
        private System.Windows.Forms.Button btnFinancialStatus;
        private System.Windows.Forms.Button btnallTansactions;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.Label lblWeeklyAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMonthlyAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label1;
    }
}
