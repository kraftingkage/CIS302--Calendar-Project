using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dddd, MMMM dd. hh:mm";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString());
        }
    }
}
