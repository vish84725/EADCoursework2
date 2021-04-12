
namespace EADCoursework2.CustomControls.InputControls
{
    partial class DropDownFieldControl
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
            this.pctBoxAdd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxAdd)).BeginInit();
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
            this.cmbBoxValue.Location = new System.Drawing.Point(200, 10);
            this.cmbBoxValue.Name = "cmbBoxValue";
            this.cmbBoxValue.Size = new System.Drawing.Size(450, 21);
            this.cmbBoxValue.TabIndex = 3;
            // 
            // pctBoxAdd
            // 
            this.pctBoxAdd.Image = global::EADCoursework2.Properties.Resources.AddButton;
            this.pctBoxAdd.Location = new System.Drawing.Point(660, 5);
            this.pctBoxAdd.Name = "pctBoxAdd";
            this.pctBoxAdd.Size = new System.Drawing.Size(30, 30);
            this.pctBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxAdd.TabIndex = 4;
            this.pctBoxAdd.TabStop = false;
            // 
            // DropDownFieldControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pctBoxAdd);
            this.Controls.Add(this.cmbBoxValue);
            this.Controls.Add(this.lblKey);
            this.Name = "DropDownFieldControl";
            this.Size = new System.Drawing.Size(700, 40);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.ComboBox cmbBoxValue;
        private System.Windows.Forms.PictureBox pctBoxAdd;
    }
}
