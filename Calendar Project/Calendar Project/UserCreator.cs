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
    public partial class UserCreator : Form
    {
        public UserCreator()
        {
            InitializeComponent();
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            String name = userName.Text;
            File.Create("usersettings.ini");
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter("usersettings.ini");
                writer.WriteLine("Name: "+ name);
            }


        }
    }
}
