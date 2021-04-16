
namespace EADCoursework2.CustomControls
{
    partial class MyEventsRowItem
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.subItemsFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(13, 15);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(74, 24);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "lblDate";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(14, 51);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(66, 24);
            this.lblDay.TabIndex = 1;
            this.lblDay.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(126, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 160);
            this.panel1.TabIndex = 2;
            // 
            // subItemsFlowLayout
            // 
            this.subItemsFlowLayout.AutoScroll = true;
            this.subItemsFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.subItemsFlowLayout.Location = new System.Drawing.Point(130, 15);
            this.subItemsFlowLayout.Name = "subItemsFlowLayout";
            this.subItemsFlowLayout.Size = new System.Drawing.Size(537, 153);
            this.subItemsFlowLayout.TabIndex = 3;
            this.subItemsFlowLayout.WrapContents = false;
            // 
            // MyEventsRowItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.subItemsFlowLayout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblDate);
            this.Name = "MyEventsRowItem";
            this.Size = new System.Drawing.Size(680, 180);
            this.Load += new System.EventHandler(this.MyEventsRowItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel subItemsFlowLayout;
    }
}
