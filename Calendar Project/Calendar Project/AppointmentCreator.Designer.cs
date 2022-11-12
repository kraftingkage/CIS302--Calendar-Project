
namespace Calendar_Project
{
    partial class AppointmentCreator
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
            this.components = new System.ComponentModel.Container();
            this.apptTitleText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.apptNotesText = new System.Windows.Forms.TextBox();
            this.apptDateTime = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.apptLocationText = new System.Windows.Forms.TextBox();
            this.apptRequiredText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // apptTitleText
            // 
            this.apptTitleText.Location = new System.Drawing.Point(110, 46);
            this.apptTitleText.Name = "apptTitleText";
            this.apptTitleText.Size = new System.Drawing.Size(240, 23);
            this.apptTitleText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Required:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Notes:";
            // 
            // apptNotesText
            // 
            this.apptNotesText.AcceptsReturn = true;
            this.apptNotesText.Location = new System.Drawing.Point(76, 194);
            this.apptNotesText.Multiline = true;
            this.apptNotesText.Name = "apptNotesText";
            this.apptNotesText.Size = new System.Drawing.Size(702, 244);
            this.apptNotesText.TabIndex = 6;
            // 
            // apptDateTime
            // 
            this.apptDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.apptDateTime.Location = new System.Drawing.Point(110, 75);
            this.apptDateTime.MinDate = new System.DateTime(2022, 11, 12, 0, 0, 0, 0);
            this.apptDateTime.Name = "apptDateTime";
            this.apptDateTime.Size = new System.Drawing.Size(240, 23);
            this.apptDateTime.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // apptLocationText
            // 
            this.apptLocationText.Location = new System.Drawing.Point(110, 109);
            this.apptLocationText.Name = "apptLocationText";
            this.apptLocationText.Size = new System.Drawing.Size(240, 23);
            this.apptLocationText.TabIndex = 9;
            // 
            // apptRequiredText
            // 
            this.apptRequiredText.Location = new System.Drawing.Point(110, 138);
            this.apptRequiredText.Name = "apptRequiredText";
            this.apptRequiredText.Size = new System.Drawing.Size(240, 23);
            this.apptRequiredText.TabIndex = 10;
            // 
            // AppointmentCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.apptRequiredText);
            this.Controls.Add(this.apptLocationText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.apptDateTime);
            this.Controls.Add(this.apptNotesText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apptTitleText);
            this.Name = "AppointmentCreator";
            this.Text = "AppointmentCreator";
            this.Load += new System.EventHandler(this.AppointmentCreator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox apptTitleText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox apptNotesText;
        private System.Windows.Forms.DateTimePicker apptDateTime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox apptLocationText;
        private System.Windows.Forms.TextBox apptRequiredText;
    }
}