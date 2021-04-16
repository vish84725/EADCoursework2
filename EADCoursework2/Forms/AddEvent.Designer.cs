
namespace EADCoursework2.Forms
{
    partial class AddEvent
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
            this.btnSaveEvent = new System.Windows.Forms.Button();
            this.toggleAppointment = new EADCoursework2.CustomControls.Components.ToggleItemControl();
            this.toggleTask = new EADCoursework2.CustomControls.Components.ToggleItemControl();
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
            // btnSaveEvent
            // 
            this.btnSaveEvent.BackColor = System.Drawing.Color.White;
            this.btnSaveEvent.ForeColor = System.Drawing.Color.Black;
            this.btnSaveEvent.Image = global::EADCoursework2.Properties.Resources.DoneButton;
            this.btnSaveEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveEvent.Location = new System.Drawing.Point(600, 451);
            this.btnSaveEvent.Name = "btnSaveEvent";
            this.btnSaveEvent.Size = new System.Drawing.Size(125, 40);
            this.btnSaveEvent.TabIndex = 7;
            this.btnSaveEvent.Text = "SAVE";
            this.btnSaveEvent.UseVisualStyleBackColor = false;
            this.btnSaveEvent.Click += new System.EventHandler(this.btnSaveEvent_Click);
            // 
            // toggleAppointment
            // 
            this.toggleAppointment.BackColor = System.Drawing.Color.White;
            this.toggleAppointment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toggleAppointment.Location = new System.Drawing.Point(400, 22);
            this.toggleAppointment.Name = "toggleAppointment";
            this.toggleAppointment.Size = new System.Drawing.Size(118, 28);
            this.toggleAppointment.TabIndex = 5;
            this.toggleAppointment.ToggleItemName = "label1";
            // 
            // toggleTask
            // 
            this.toggleTask.BackColor = System.Drawing.Color.White;
            this.toggleTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toggleTask.Location = new System.Drawing.Point(282, 22);
            this.toggleTask.Name = "toggleTask";
            this.toggleTask.Size = new System.Drawing.Size(118, 28);
            this.toggleTask.TabIndex = 4;
            this.toggleTask.ToggleItemName = "label1";
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.btnSaveEvent);
            this.Controls.Add(this.flowPnlInputs);
            this.Controls.Add(this.toggleAppointment);
            this.Controls.Add(this.toggleTask);
            this.Name = "AddEvent";
            this.Text = "AddEvent";
            this.Load += new System.EventHandler(this.AddEvent_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.Components.ToggleItemControl toggleAppointment;
        private CustomControls.Components.ToggleItemControl toggleTask;
        private System.Windows.Forms.FlowLayoutPanel flowPnlInputs;
        private System.Windows.Forms.Button btnSaveEvent;
    }
}