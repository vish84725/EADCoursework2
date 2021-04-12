
namespace EADCoursework2.CustomControls.InputControls
{
    partial class RecurrentDropDownFieldControl
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
            this.lblKey = new System.Windows.Forms.Label();
            this.cmbBoxValue = new System.Windows.Forms.ComboBox();
            this.chkBoxSelect = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.ForeColor = System.Drawing.Color.Black;
            this.lblKey.Location = new System.Drawing.Point(50, 12);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(47, 15);
            this.lblKey.TabIndex = 2;
            this.lblKey.Text = "label1";
            // 
            // cmbBoxValue
            // 
            this.cmbBoxValue.FormattingEnabled = true;
            this.cmbBoxValue.Location = new System.Drawing.Point(220, 10);
            this.cmbBoxValue.Name = "cmbBoxValue";
            this.cmbBoxValue.Size = new System.Drawing.Size(430, 21);
            this.cmbBoxValue.TabIndex = 3;
            this.cmbBoxValue.Visible = false;
            // 
            // chkBoxSelect
            // 
            this.chkBoxSelect.AutoSize = true;
            this.chkBoxSelect.Location = new System.Drawing.Point(200, 14);
            this.chkBoxSelect.Name = "chkBoxSelect";
            this.chkBoxSelect.Size = new System.Drawing.Size(15, 14);
            this.chkBoxSelect.TabIndex = 4;
            this.chkBoxSelect.UseVisualStyleBackColor = true;
            this.chkBoxSelect.CheckStateChanged += new System.EventHandler(this.chkBoxSelect_CheckStateChanged);
            // 
            // RecurrentDropDownFieldControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkBoxSelect);
            this.Controls.Add(this.cmbBoxValue);
            this.Controls.Add(this.lblKey);
            this.Name = "RecurrentDropDownFieldControl";
            this.Size = new System.Drawing.Size(700, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.ComboBox cmbBoxValue;
        private System.Windows.Forms.CheckBox chkBoxSelect;
    }
}
