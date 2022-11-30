
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
            this.createButton = new System.Windows.Forms.Button();
            this.apptLocationText = new System.Windows.Forms.TextBox();
            this.apptRequiredText = new System.Windows.Forms.TextBox();
            this.modifyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.optionalText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sendInviteButton = new System.Windows.Forms.Button();
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
            this.apptDateTime.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(713, 12);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 7;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // apptLocationText
            // 
            this.apptLocationText.Location = new System.Drawing.Point(110, 109);
            this.apptLocationText.Name = "apptLocationText";
            this.apptLocationText.Size = new System.Drawing.Size(240, 23);
            this.apptLocationText.TabIndex = 2;
            // 
            // apptRequiredText
            // 
            this.apptRequiredText.Location = new System.Drawing.Point(110, 138);
            this.apptRequiredText.Name = "apptRequiredText";
            this.apptRequiredText.Size = new System.Drawing.Size(240, 23);
            this.apptRequiredText.TabIndex = 3;
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(713, 12);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(75, 23);
            this.modifyButton.TabIndex = 7;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(632, 12);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(632, 12);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // optionalText
            // 
            this.optionalText.Location = new System.Drawing.Point(419, 141);
            this.optionalText.Name = "optionalText";
            this.optionalText.Size = new System.Drawing.Size(240, 23);
            this.optionalText.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Optional:";
            // 
            // sendInviteButton
            // 
            this.sendInviteButton.Location = new System.Drawing.Point(665, 144);
            this.sendInviteButton.Name = "sendInviteButton";
            this.sendInviteButton.Size = new System.Drawing.Size(75, 23);
            this.sendInviteButton.TabIndex = 5;
            this.sendInviteButton.Text = "Send Invite";
            this.sendInviteButton.UseVisualStyleBackColor = true;
            this.sendInviteButton.Click += new System.EventHandler(this.sendInviteButton_Click);
            // 
            // AppointmentCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendInviteButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.optionalText);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.apptRequiredText);
            this.Controls.Add(this.apptLocationText);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.apptDateTime);
            this.Controls.Add(this.apptNotesText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apptTitleText);
            this.Name = "AppointmentCreator";
            this.Text = "Appointment";
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
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox apptLocationText;
        private System.Windows.Forms.TextBox apptRequiredText;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox optionalText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button sendInviteButton;
    }
}