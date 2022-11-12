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

namespace Calendar_Project
{
    public partial class AppointmentCreator : Form
    {
        public AppointmentCreator()
        {
            InitializeComponent();

        }

        private void AppointmentCreator_Load(object sender, EventArgs e)
        {
            setCustomDateTime();
        }
        private void setCustomDateTime()
        {
            apptDateTime.Format = DateTimePickerFormat.Custom;
            apptDateTime.CustomFormat = "dddd, MMMM dd. hh:mm";
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
            var apppath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var dirpath = Path.Combine(apppath,"CIS302CalendarKAC/appointments");
            Directory.CreateDirectory(dirpath);
            var filepath = Path.Combine(dirpath, $@"{ time.ToString("yyyyMMddhhmm") }.ini"); 
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
            }
            else
            {
                MessageBox.Show("There is an appointment with the same start time already on your calendar. Please either remove the existing appointment or select a new start time for this appointment.");
            }
        }
    }
}
