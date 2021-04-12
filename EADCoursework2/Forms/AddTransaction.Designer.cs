
namespace EADCoursework2.Forms
{
    partial class AddTransaction
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
            this.flowPnlInputs = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.toggleExpense = new EADCoursework2.CustomControls.Components.ToggleItemControl();
            this.toggleIncome = new EADCoursework2.CustomControls.Components.ToggleItemControl();
            this.SuspendLayout();
            // 
            // flowPnlInputs
            // 
            this.flowPnlInputs.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPnlInputs.Location = new System.Drawing.Point(34, 77);
            this.flowPnlInputs.Name = "flowPnlInputs";
            this.flowPnlInputs.Size = new System.Drawing.Size(716, 357);
            this.flowPnlInputs.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::EADCoursework2.Properties.Resources.DoneButton;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(610, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // toggleExpense
            // 
            this.toggleExpense.BackColor = System.Drawing.Color.White;
            this.toggleExpense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toggleExpense.Location = new System.Drawing.Point(403, 28);
            this.toggleExpense.Name = "toggleExpense";
            this.toggleExpense.Size = new System.Drawing.Size(118, 28);
            this.toggleExpense.TabIndex = 3;
            this.toggleExpense.ToggleItemName = "label1";
            // 
            // toggleIncome
            // 
            this.toggleIncome.BackColor = System.Drawing.Color.White;
            this.toggleIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toggleIncome.Location = new System.Drawing.Point(285, 28);
            this.toggleIncome.Name = "toggleIncome";
            this.toggleIncome.Size = new System.Drawing.Size(118, 28);
            this.toggleIncome.TabIndex = 2;
            this.toggleIncome.ToggleItemName = "label1";
            // 
            // AddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.toggleExpense);
            this.Controls.Add(this.toggleIncome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowPnlInputs);
            this.Name = "AddTransaction";
            this.Text = "AddTransaction";
            this.Load += new System.EventHandler(this.AddTransaction_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowPnlInputs;
        private System.Windows.Forms.Button button1;
        private CustomControls.Components.ToggleItemControl toggleIncome;
        private CustomControls.Components.ToggleItemControl toggleExpense;
    }
}