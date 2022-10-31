
namespace Calendar_Project
{
    partial class UserControl1
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
        private void InitializeComponent(string holder)
        {
            this.eventTime = new System.Windows.Forms.Label();
            this.eventTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eventTime
            // 
            this.eventTime.AutoSize = true;
            this.eventTime.Location = new System.Drawing.Point(4, 4);
            this.eventTime.Name = "eventTime";
            this.eventTime.Size = new System.Drawing.Size(62, 15);
            this.eventTime.TabIndex = 0;
            this.eventTime.Text = "eventTime";
            // 
            // eventTitle
            // 
            this.eventTitle.AutoSize = true;
            this.eventTitle.Location = new System.Drawing.Point(88, 4);
            this.eventTitle.Name = "eventTitle";
            this.eventTitle.Size = new System.Drawing.Size(58, 15);
            this.eventTitle.TabIndex = 1;
            this.eventTitle.Text = "eventTitle";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.eventTitle);
            this.Controls.Add(this.eventTime);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(200, 36);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eventTime;
        private System.Windows.Forms.Label eventTitle;
    }
}
