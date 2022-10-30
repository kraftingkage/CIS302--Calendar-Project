﻿using System;
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
    public partial class UserControl1 : UserControl
    {

        string holder;
        public UserControl1(string names)
        {
            InitializeComponent(names);
            holder = names;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            eventTime.Text = holder;
        }
    }
}
