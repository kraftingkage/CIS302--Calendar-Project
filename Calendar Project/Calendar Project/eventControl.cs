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
        string hname,htitle;
        public eventControl(string names, string title)
        {
            InitializeComponent();
            hname = names;
            htitle = title;
        }

        private void eventControl_Load(object sender, EventArgs e)
        {
            eventTime.Text = hname;
            eventTitle.Text = htitle;
        }
    }
}
