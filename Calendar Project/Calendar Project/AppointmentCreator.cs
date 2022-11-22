using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Calendar_Project
{
    #region InitClass
    public partial class AppointmentCreator : Form
    {
        string state;
        string appdatapath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CIS302CalendarKAC/appointments");
        bool update = false;
        public AppointmentCreator(string state)
        {
            InitializeComponent();
            this.state = state;
        }

        private void AppointmentCreator_Load(object sender, EventArgs e)
        {
            setCustomDateTime();
            if(this.state == "create")
            {
                deleteButton.Visible = false;
                modifyButton.Visible = false;
            }else if(state == "modify")
            {
                createButton.Visible = false;
                cancelButton.Visible = false;
            }
        }

        public void passVar(string title, DateTime time, string location, string required, string optional, string notes)
        {
            apptTitleText.Text = title;
            apptDateTime.Value = time;
            apptLocationText.Text = location;
            apptRequiredText.Text = required;
            optionalText.Text = optional;
            apptNotesText.Text = notes.Replace("\n","\r\n");
            update = true;
            this.Text = title;
    }
        private void setCustomDateTime()
        {
            apptDateTime.Format = DateTimePickerFormat.Custom;
            apptDateTime.CustomFormat = "dddd, MMMM dd. hh:mm tt";
        }
        #endregion








        #region AppointmentControl
        //CreateNewAppointment can be called from anywhere, for modularity, however will likely only be called from this class.
        public void CreateNewAppoitnment(string title, DateTime time, string location, string required, string optional, string notes)
        {
            string invupda;
            Directory.CreateDirectory(appdatapath);
            var filepath = Path.Combine(appdatapath, $@"{ time.ToString("yyyyMMddHHmm") }.ini");
            /* 
             * Requires title, datetime, location, required, & notes. Feilds can be blank, excluding date. Opens the existing appointment data file and appends a new line.
             * 
             */
            if (!File.Exists(filepath))
            {

                StreamWriter w = new StreamWriter(filepath);
                w.WriteLine(title);
                w.WriteLine(time.ToString());
                w.WriteLine(location);
                w.WriteLine(required);
                w.WriteLine(optional);
                w.WriteLine(notes);
                w.Close();

                MessageBox.Show("Appointment has been created/modified, to see this update please click the refresh button on your calendar.");
                this.Close();


            }
            else
            {
                MessageBox.Show("There is an appointment with the same start time already on your calendar. Please either remove the existing appointment or select a new start time for this appointment.");
            }
        }
        public void DeleteAppointment()
        {
            var delfilepath = Path.Combine(appdatapath, $@"{apptDateTime.Value.ToString("yyyyMMddHHmm")}.ini");
            File.Delete(delfilepath);
        }

        private void SendEmail(string required, string cc, string invupda, string title, DateTime time, string location, string notes)
        {
            string mailto = $"mailto:{required}?Cc={cc}&subject={invupda}: {title}&body=Title: {title}%0ADate: {time.ToString()}%0ALocation: {location}%0A%0A%0A{notes}";
            Process p = new Process();
            p.StartInfo.UseShellExecute = true;
            p.StartInfo.FileName = mailto;
            p.Start();
        }

        #endregion



        #region ButtonControls
        private void button1_Click(object sender, EventArgs e)
        {
            //Grabs the text/datetime from text boxes on form and invokes CreateNewAppointment
            CreateNewAppoitnment(apptTitleText.Text, apptDateTime.Value, apptLocationText.Text, apptRequiredText.Text, optionalText.Text, apptNotesText.Text);
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this appointment?", "Confirm Delete", MessageBoxButtons.YesNo);
            if(confirmResult == DialogResult.Yes)
            {
                DeleteAppointment();
            }
            else
            {
                //Do nothing for now
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            DeleteAppointment();
            MessageBox.Show(apptTitleText.Text + apptDateTime.Value + apptLocationText.Text + apptRequiredText.Text + apptNotesText.Text);
            CreateNewAppoitnment(apptTitleText.Text, apptDateTime.Value, apptLocationText.Text, apptRequiredText.Text, optionalText.Text, apptNotesText.Text);
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sendInviteButton_Click(object sender, EventArgs e)
        {
            string subj = "You have been invited to";
            if (update)
            {
                subj = "UPDATE You have been invited to";
            }
            SendEmail(apptRequiredText.Text, optionalText.Text, subj , apptTitleText.Text, apptDateTime.Value, apptLocationText.Text, apptNotesText.Text.Replace("\r\n", "%0A"));
         
        }
        #endregion
    }
}
