
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
            // MyEventsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.myEventsFlowLayout);
            this.Name = "MyEventsUserControl";
            this.Size = new System.Drawing.Size(740, 320);
            this.Load += new System.EventHandler(this.MyEventsUserControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel myEventsFlowLayout;
    }
}
