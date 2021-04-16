
namespace EADCoursework2.CustomControls
{
    partial class MyEventsUserControl
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
            this.myEventsFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.addEventPictureBox = new System.Windows.Forms.PictureBox();
            this.datePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.datePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toggleAll = new EADCoursework2.CustomControls.Components.ToggleItemControl();
            this.toggleEvents = new EADCoursework2.CustomControls.Components.ToggleItemControl();
            this.toggleTransactions = new EADCoursework2.CustomControls.Components.ToggleItemControl();
            this.btnFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.addEventPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // myEventsFlowLayout
            // 
            this.myEventsFlowLayout.AutoScroll = true;
            this.myEventsFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.myEventsFlowLayout.Location = new System.Drawing.Point(17, 68);
            this.myEventsFlowLayout.Name = "myEventsFlowLayout";
            this.myEventsFlowLayout.Size = new System.Drawing.Size(706, 236);
            this.myEventsFlowLayout.TabIndex = 0;
            this.myEventsFlowLayout.WrapContents = false;
            this.myEventsFlowLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.myEventsFlowLayout_Paint);
            // 
            // addEventPictureBox
            // 
            this.addEventPictureBox.Image = global::EADCoursework2.Properties.Resources.add_circle_black_24dp;
            this.addEventPictureBox.Location = new System.Drawing.Point(692, 21);
            this.addEventPictureBox.Name = "addEventPictureBox";
            this.addEventPictureBox.Size = new System.Drawing.Size(35, 35);
            this.addEventPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addEventPictureBox.TabIndex = 1;
            this.addEventPictureBox.TabStop = false;
            this.addEventPictureBox.Click += new System.EventHandler(this.addEventPictureBox_Click);
            // 
            // datePickerFrom
            // 
            this.datePickerFrom.Location = new System.Drawing.Point(45, 14);
            this.datePickerFrom.Name = "datePickerFrom";
            this.datePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.datePickerFrom.TabIndex = 5;
            // 
            // datePickerTo
            // 
            this.datePickerTo.Location = new System.Drawing.Point(45, 39);
            this.datePickerTo.Name = "datePickerTo";
            this.datePickerTo.Size = new System.Drawing.Size(200, 20);
            this.datePickerTo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "To";
            // 
            // toggleAll
            // 
            this.toggleAll.BackColor = System.Drawing.Color.White;
            this.toggleAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toggleAll.Location = new System.Drawing.Point(344, 25);
            this.toggleAll.Name = "toggleAll";
            this.toggleAll.Size = new System.Drawing.Size(118, 28);
            this.toggleAll.TabIndex = 4;
            this.toggleAll.ToggleItemName = "label1";
            // 
            // toggleEvents
            // 
            this.toggleEvents.BackColor = System.Drawing.Color.White;
            this.toggleEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toggleEvents.Location = new System.Drawing.Point(460, 25);
            this.toggleEvents.Name = "toggleEvents";
            this.toggleEvents.Size = new System.Drawing.Size(118, 28);
            this.toggleEvents.TabIndex = 3;
            this.toggleEvents.ToggleItemName = "label1";
            // 
            // toggleTransactions
            // 
            this.toggleTransactions.BackColor = System.Drawing.Color.White;
            this.toggleTransactions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toggleTransactions.Location = new System.Drawing.Point(568, 25);
            this.toggleTransactions.Name = "toggleTransactions";
            this.toggleTransactions.Size = new System.Drawing.Size(118, 28);
            this.toggleTransactions.TabIndex = 2;
            this.toggleTransactions.ToggleItemName = "label1";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(259, 25);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 9;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // MyEventsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datePickerTo);
            this.Controls.Add(this.datePickerFrom);
            this.Controls.Add(this.toggleAll);
            this.Controls.Add(this.toggleEvents);
            this.Controls.Add(this.toggleTransactions);
            this.Controls.Add(this.addEventPictureBox);
            this.Controls.Add(this.myEventsFlowLayout);
            this.Name = "MyEventsUserControl";
            this.Size = new System.Drawing.Size(740, 320);
            this.Load += new System.EventHandler(this.MyEventsUserControl_Load);
            this.Click += new System.EventHandler(this.MyEventsUserControl_Click);
            ((System.ComponentModel.ISupportInitialize)(this.addEventPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel myEventsFlowLayout;
        private System.Windows.Forms.PictureBox addEventPictureBox;
        private Components.ToggleItemControl toggleTransactions;
        private Components.ToggleItemControl toggleEvents;
        private Components.ToggleItemControl toggleAll;
        private System.Windows.Forms.DateTimePicker datePickerFrom;
        private System.Windows.Forms.DateTimePicker datePickerTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFilter;
    }
}
