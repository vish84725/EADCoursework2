
namespace EADCoursework2.Forms
{
    partial class AddPayerPayee
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
            this.togglePayee = new EADCoursework2.CustomControls.Components.ToggleItemControl();
            this.togglePayer = new EADCoursework2.CustomControls.Components.ToggleItemControl();
            this.SuspendLayout();
            // 
            // flowPnlInputs
            // 
            this.flowPnlInputs.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPnlInputs.Location = new System.Drawing.Point(42, 69);
            this.flowPnlInputs.Name = "flowPnlInputs";
            this.flowPnlInputs.Size = new System.Drawing.Size(716, 357);
            this.flowPnlInputs.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::EADCoursework2.Properties.Resources.DoneButton;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(600, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // togglePayee
            // 
            this.togglePayee.BackColor = System.Drawing.Color.White;
            this.togglePayee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.togglePayee.Location = new System.Drawing.Point(400, 22);
            this.togglePayee.Name = "togglePayee";
            this.togglePayee.Size = new System.Drawing.Size(118, 28);
            this.togglePayee.TabIndex = 5;
            this.togglePayee.ToggleItemName = "label1";
            // 
            // togglePayer
            // 
            this.togglePayer.BackColor = System.Drawing.Color.White;
            this.togglePayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.togglePayer.Location = new System.Drawing.Point(282, 22);
            this.togglePayer.Name = "togglePayer";
            this.togglePayer.Size = new System.Drawing.Size(118, 28);
            this.togglePayer.TabIndex = 4;
            this.togglePayer.ToggleItemName = "label1";
            // 
            // AddPayerPayee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowPnlInputs);
            this.Controls.Add(this.togglePayee);
            this.Controls.Add(this.togglePayer);
            this.Name = "AddPayerPayee";
            this.Text = "AddEvent";
            this.Load += new System.EventHandler(this.AddEvent_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.Components.ToggleItemControl togglePayee;
        private CustomControls.Components.ToggleItemControl togglePayer;
        private System.Windows.Forms.FlowLayoutPanel flowPnlInputs;
        private System.Windows.Forms.Button button1;
    }
}