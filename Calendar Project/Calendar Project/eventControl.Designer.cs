
namespace Calendar_Project
{
    partial class eventControl
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
            this.eventTime = new System.Windows.Forms.Label();
            this.eventTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eventTime
            // 
            this.eventTime.AutoSize = true;
            this.eventTime.BackColor = System.Drawing.Color.Transparent;
            this.eventTime.Location = new System.Drawing.Point(0, 6);
            this.eventTime.Name = "eventTime";
            this.eventTime.Size = new System.Drawing.Size(38, 15);
            this.eventTime.TabIndex = 0;
            this.eventTime.Text = "label1";
            // 
            // eventTitle
            // 
            this.eventTitle.AutoSize = true;
            this.eventTitle.BackColor = System.Drawing.Color.Transparent;
            this.eventTitle.ForeColor = System.Drawing.Color.Blue;
            this.eventTitle.Location = new System.Drawing.Point(61, 6);
            this.eventTitle.Name = "eventTitle";
            this.eventTitle.Size = new System.Drawing.Size(38, 15);
            this.eventTitle.TabIndex = 1;
            this.eventTitle.Text = "label1";
            this.eventTitle.Click += new System.EventHandler(this.eventTitle_Click);
            // 
            // eventControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.eventTitle);
            this.Controls.Add(this.eventTime);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "eventControl";
            this.Size = new System.Drawing.Size(194, 25);
            this.Load += new System.EventHandler(this.eventControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eventTime;
        private System.Windows.Forms.Label eventTitle;
    }
}
