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
using static Calendar_Project.Form1;

namespace Calendar_Project
{
    public partial class AppointmentCreator : Form
    {
        string state;
        string appdatapath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CIS302CalendarKAC/appointments");
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

        public void passVar(string title, DateTime time, string location, string required, string notes)
        {
            apptTitleText.Text = title;
            apptDateTime.Value = time;
            apptLocationText.Text = location;
            apptRequiredText.Text = required;
            apptNotesText.Text = notes;
            
            this.Text = title;
        }
        private void setCustomDateTime()
        {
            apptDateTime.Format = DateTimePickerFormat.Custom;
            apptDateTime.CustomFormat = "dddd, MMMM dd. hh:mm tt";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Grabs the text/datetime from text boxes on form and invokes CreateNewAppointment
            CreateNewAppoitnment(apptTitleText.Text, apptDateTime.Value, apptLocationText.Text, apptRequiredText.Text, apptNotesText.Text);
            MessageBox.Show(apptDateTime.Value.ToString());
        }

        //CreateNewAppointment can be called from anywhere, for modularity, however will likely only be called from this class.
        public void CreateNewAppoitnment(string title, DateTime time, string location, string required, string notes)
        {
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
                w.WriteLine(notes);
                w.Close();

                MessageBox.Show(@$"Appointment Created {time.ToString("yyyyMMddHHmm")}");
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
            CreateNewAppoitnment(apptTitleText.Text, apptDateTime.Value, apptLocationText.Text, apptRequiredText.Text, apptNotesText.Text);
            
        }
    }
}
