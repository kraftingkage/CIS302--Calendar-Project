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
    public partial class eventControl : UserControl
    {
        private string title,location,required,notes;

        private void eventTitle_Click(object sender, EventArgs e)
        {
            AppointmentCreator f = new AppointmentCreator("modify");
            f.Show();
            f.passVar(this.title,this.date,this.location,this.required,this.notes);
        }

        private DateTime date;
        public eventControl(string title, DateTime date, string location, string required, string notes)
        {
            InitializeComponent();
            this.title = title;
            this.location = location;
            this.required = required;
            this.notes = notes;
            this.date = date;
        }

        private void eventControl_Load(object sender, EventArgs e)
        {
            eventTime.Text = this.date.ToString("hh:mm");
            eventTitle.Text = this.title;
        }
    }
}
